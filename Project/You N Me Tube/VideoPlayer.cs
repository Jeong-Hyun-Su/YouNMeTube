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
        private Point mousePoint;                   //폼 이동 시 사용하는 변수

        public VideoPlayer()
        {
            InitializeComponent();
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
