using CefSharp.WinForms;
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using System.Linq;

namespace You_N_Me_Tube
{
    public partial class Search : Form
    {
        ChromiumWebBrowser browser;
      
        private Point mousePoint;

        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            CefSettings setting = new CefSettings();
            if (!Cef.IsInitialized)
                Cef.Initialize(setting);

            browser = new ChromiumWebBrowser();
            pn_video.Controls.Add(browser); //브라우저를 Panel에 표시
            browser.Size = new System.Drawing.Size(758, 526);
            browser.Dock = DockStyle.Fill; //Panel 에 꽉 차도록 설정
        }

        // 마우스 클릭시 먼저 선언된 mousePoint변수에 현재 마우스 위치값이 들어감
        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        // 클릭상태로 마우스를 이동시 이동한 만큼에서 윈도우 위치값을 뺌
        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }
       

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }


        private async Task Run()
        {
            lstBox.Items.Clear();   // 리스트박스 초기화

            // 유튜브 Data API 서비스 형성
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                // Google API 키
                ApiKey = "AIzaSyCA5cM5DNyepHev3pEc2kl4kZ97_WEzNhA",
                ApplicationName = this.GetType().ToString()
            });

            var searchListRequest = youtubeService.Search.List("snippet");
            searchListRequest.Q = tb_Search.Text;                    // 검색 키워드
            searchListRequest.MaxResults = 20;              // 최대 검색결과 갯수

            var searchListResponse = await searchListRequest.ExecuteAsync();

            List<string> videos = new List<string>();       // 비디오 관련 정보 담을 List
            //List<string> channels = new List<string>();
            //List<string> playlists = new List<string>();

            foreach (var searchResult in searchListResponse.Items)
            {
                switch (searchResult.Id.Kind)
                {
                    case "youtube#video":       // 비디오 키워드
                        videos.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.VideoId));
                        lstBox.Items.Add(searchResult.Snippet.Title + " - " + searchResult.Id.VideoId);
                        break;

                        //case "youtube#channel":
                        //    channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.ChannelId));
                        //    break;

                        //case "youtube#playlist":
                        //    channels.Add(String.Format("{0} ({1})", searchResult.Snippet.Title, searchResult.Id.PlaylistId));
                        //    break;
                }
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            this.Run();
            //"https://youtube.com/embed/" + item.ToString() + "?autoplay=1";
        }

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] items_name;
            char[] arr = " - ".ToCharArray();
            items_name = lstBox.SelectedItem.ToString().Split(arr);

            int sayi = 0;

            foreach (var item in items_name)
            {
                sayi += 1;
                if (sayi == items_name.Count())
                {
                    MessageBox.Show(item.ToString());
                    browser.Load("https://youtube.com/embed/" + item.ToString() + "?autoplay=1");
                }
            }
        }
    }
}