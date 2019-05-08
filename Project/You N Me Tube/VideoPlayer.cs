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
        int i = 0;
        public VideoPlayer()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            i++;
            this.Hide();
        }

        private void m_notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void VideoPlayer_Resize(object sender, EventArgs e)
        {

        }
    }
}
