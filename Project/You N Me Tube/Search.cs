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
    public partial class Search : Form
    {
        private Point mousePoint;

        public Search()
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
            Close();
        }
    }
}