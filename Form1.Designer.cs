
namespace demo1
{
    partial class 小车运动
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(小车运动));
            this.Car_picture = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_quick = new System.Windows.Forms.Button();
            this.button_slow = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Car_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Car_picture
            // 
            this.Car_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Car_picture.Image = ((System.Drawing.Image)(resources.GetObject("Car_picture.Image")));
            this.Car_picture.Location = new System.Drawing.Point(0, -1);
            this.Car_picture.Name = "Car_picture";
            this.Car_picture.Size = new System.Drawing.Size(129, 68);
            this.Car_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Car_picture.TabIndex = 0;
            this.Car_picture.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(12, 406);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(59, 37);
            this.button_start.TabIndex = 1;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_quick
            // 
            this.button_quick.Location = new System.Drawing.Point(77, 406);
            this.button_quick.Name = "button_quick";
            this.button_quick.Size = new System.Drawing.Size(59, 37);
            this.button_quick.TabIndex = 2;
            this.button_quick.Text = "加速";
            this.button_quick.UseVisualStyleBackColor = true;
            this.button_quick.Click += new System.EventHandler(this.button_quick_Click);
            // 
            // button_slow
            // 
            this.button_slow.Location = new System.Drawing.Point(142, 406);
            this.button_slow.Name = "button_slow";
            this.button_slow.Size = new System.Drawing.Size(59, 37);
            this.button_slow.TabIndex = 3;
            this.button_slow.Text = "减速";
            this.button_slow.UseVisualStyleBackColor = true;
            this.button_slow.Click += new System.EventHandler(this.button_slow_Click);
            // 
            // button_stop
            // 
            this.button_stop.Location = new System.Drawing.Point(207, 406);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(59, 37);
            this.button_stop.TabIndex = 4;
            this.button_stop.Text = "暂停";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // 小车运动
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 503);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_slow);
            this.Controls.Add(this.button_quick);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.Car_picture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "小车运动";
            this.Text = "小车运动";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.小车运动_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Car_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Car_picture;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_quick;
        private System.Windows.Forms.Button button_slow;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

