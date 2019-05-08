using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace You_N_Me_Tube
{
    public partial class MusicPlayer : Form
    {
        public MusicPlayer()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ChangeToVideo_Click(object sender, EventArgs e)
        {
            (new VideoPlayer()).Show(); this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }
    }
}