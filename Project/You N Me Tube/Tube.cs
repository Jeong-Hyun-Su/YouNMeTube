using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DotNetOpenAuth.OAuth2;

using Google.Apis.Auth;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util;
using Google.Apis.YouTube.v3;
using Google.Apis.YouTube.v3.Data;
using YoutubeSearch;

namespace You_N_Me_Tube
{
    public partial class Tube : Form
    {
        public Tube()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        void bt_SearchOk_Click(object sender, EventArgs e)
        {
            Run();
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

            foreach(var searchResult in searchListResponse.Items)
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

        private void lstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] items_name;
            char[] arr = " - ".ToCharArray();
            items_name = lstBox.SelectedItem.ToString().Split(arr);

            int sayi = 0;

            foreach(var item in items_name)
            {
                sayi += 1;
                if( sayi == items_name.Count())
                {
                    ShockWave.Movie = "https://youtube.com/v/" + item.ToString() + "/";
                    
                }
            }
        }
    }
}
