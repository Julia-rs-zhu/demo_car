using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo1
{
    public partial class 小车运动 : Form
    {
        public 小车运动()
        {
            InitializeComponent();
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            timer.Interval = 30;
            timer.Start();
        }

        private void button_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int x = Car_picture.Location.X + 8;
            int y = Car_picture.Location.Y + 5;
            if (x > this.Width | y > this.Height)
            {
                x = 0;
                y = 0;
            }
            Car_picture.Location = new Point(x, y);
            Car_picture.Refresh();
        }

        private void button_quick_Click(object sender, EventArgs e)
        {
            timer.Interval = 10;
        }

        private void button_slow_Click(object sender, EventArgs e)
        {
            timer.Interval = 50;
        }

        private void 小车运动_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            notifyIcon1.Visible = true;
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (MessageBox.Show("是否关闭程序？", "提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Dispose();
                    Close();
                }
            }

        }
    }
}
