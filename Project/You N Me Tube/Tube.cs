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
            tb_Search.Text = "exo";
        }

        public void EucKrToUtf8(string hangle)
        {
            var eucKrEncoding = Encoding.GetEncoding("euc-kr");
            var utf8Encoding = Encoding.UTF8;

            string eucKrString = eucKrEncoding.GetString(eucKrEncoding.GetBytes(hangle));
            var resultOfUtf8Bytes = utf8Encoding.GetBytes(eucKrString);

            string str = utf8Encoding.GetString(resultOfUtf8Bytes);
            MessageBox.Show(str);
            // Assert
            if (utf8Encoding.GetString(resultOfUtf8Bytes) != hangle) throw new Exception();
        }

        void bt_SearchOk_Click(object sender, EventArgs e)
        {
            VideoSearch items = new VideoSearch();
            List<Video> list = new List<Video>();
            foreach(var item in items.SearchQuery(tb_Search.Text, 1))
            {
                Video video = new Video();
                
                byte[] bytes = Encoding.UTF8.GetBytes(item.Title);
                video.Title = Encoding.UTF8.GetString(bytes);

                video.Author = item.Author;
                video.Url = item.Url;
                byte[] imageBytes = new WebClient().DownloadData(item.Thumbnail);
                using(MemoryStream ms = new MemoryStream(imageBytes))
                {
                    video.Thumbnail = Image.FromStream(ms);
                }
                list.Add(video);
            }
            videoBindingSource.DataSource = list;
        }

    }
}
