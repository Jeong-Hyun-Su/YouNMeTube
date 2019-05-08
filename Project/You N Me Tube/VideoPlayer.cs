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
    public partial class VideoPlayer : Form
    {
        public VideoPlayer()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_ChangeToMusic_Click(object sender, EventArgs e)
        {
            (new MusicPlayer()).Show(); this.Close();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
        }

        private void VideoPlayer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            m_notify.Visible = true;
            this.WindowState = FormWindowState.Minimized;
            this.Hide();

        }

        private void m_notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Notify Icon을 더블클릭했을시 일어나는 이벤트.
            this.Show();
            this.WindowState = FormWindowState.Normal;  //normal 사이즈
            m_notify.Visible = false;   //트레이 아이콘을 숨긴다
        }

        private void VideoPlayer_Resize(object sender, EventArgs e)
        {
            //윈동 상태가 Minimized일 경우
            if (this.WindowState == FormWindowState.Minimized)
            {
                m_notify.Visible = true;    //트레이 아이콘을 표시한다. 
                this.Hide();
            }
            else
            {
                m_notify.Visible = false;
                this.ShowInTaskbar = true;
            }
        }

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
