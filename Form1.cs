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
//开始
        private void button_start_Click(object sender, EventArgs e)
        {
            timer.Interval = 30;                              //时间间隔（单位 ms）
            timer.Start();                                    //开始
        }
//暂停
        private void button_stop_Click(object sender, EventArgs e)
        {
            timer.Stop();                                    //停止
        }
//移动
        private void timer_Tick(object sender, EventArgs e)
        {
            int x = Car_picture.Location.X + 8;                //横坐标移动
            int y = Car_picture.Location.Y + 5;                //纵坐标移动
            if (x > this.Width | y > this.Height)
            {
                x = 0;
                y = 0;
            }
            Car_picture.Location = new Point(x, y);            //更新小车位置
            Car_picture.Refresh();                             //刷新
        }
//加速
        private void button_quick_Click(object sender, EventArgs e)
        {
            timer.Interval = 10;                                 //加速
        }
//减速
        private void button_slow_Click(object sender, EventArgs e)
        {
            timer.Interval = 50;                                //减速                              
        }
 //托盘
        private void 小车运动_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;                              //取消关闭窗体
            this.Hide();                                   //隐藏窗体
            notifyIcon1.Visible = true;                     //任务栏显示图标
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();                                             //显示窗体
            this.WindowState = FormWindowState.Normal;                 //窗体显示为正常大
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (MessageBox.Show("是否关闭程序？", "提示：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    Dispose();
                    Close();                                       //关闭窗体
                }
            }

        }
    }
}
