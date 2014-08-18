namespace SystemTest
{
    partial class MainWindow
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.cpu = new System.Windows.Forms.TabControl();
            this.tabcpu = new System.Windows.Forms.TabPage();
            this.cpustop = new System.Windows.Forms.Button();
            this.cpustart = new System.Windows.Forms.Button();
            this.yingpantabPage2 = new System.Windows.Forms.TabPage();
            this.yingpanstop = new System.Windows.Forms.Button();
            this.yingpanstart = new System.Windows.Forms.Button();
            this.process1 = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.cpu.SuspendLayout();
            this.tabcpu.SuspendLayout();
            this.yingpantabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // cpu
            // 
            this.cpu.Controls.Add(this.tabcpu);
            this.cpu.Controls.Add(this.yingpantabPage2);
            this.cpu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpu.Location = new System.Drawing.Point(0, 0);
            this.cpu.Name = "cpu";
            this.cpu.SelectedIndex = 0;
            this.cpu.Size = new System.Drawing.Size(334, 157);
            this.cpu.TabIndex = 0;
            // 
            // tabcpu
            // 
            this.tabcpu.Controls.Add(this.cpustop);
            this.tabcpu.Controls.Add(this.cpustart);
            this.tabcpu.Location = new System.Drawing.Point(4, 22);
            this.tabcpu.Name = "tabcpu";
            this.tabcpu.Padding = new System.Windows.Forms.Padding(3);
            this.tabcpu.Size = new System.Drawing.Size(326, 131);
            this.tabcpu.TabIndex = 0;
            this.tabcpu.Text = "cpu压力模拟";
            this.tabcpu.UseVisualStyleBackColor = true;
            // 
            // cpustop
            // 
            this.cpustop.Location = new System.Drawing.Point(167, 54);
            this.cpustop.Name = "cpustop";
            this.cpustop.Size = new System.Drawing.Size(140, 23);
            this.cpustop.TabIndex = 1;
            this.cpustop.Text = "停止CPU压力模拟";
            this.cpustop.UseVisualStyleBackColor = true;
            this.cpustop.Click += new System.EventHandler(this.cpustop_Click);
            // 
            // cpustart
            // 
            this.cpustart.Location = new System.Drawing.Point(8, 55);
            this.cpustart.Name = "cpustart";
            this.cpustart.Size = new System.Drawing.Size(125, 23);
            this.cpustart.TabIndex = 0;
            this.cpustart.Text = "开始CPU压力模拟";
            this.cpustart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cpustart.UseVisualStyleBackColor = true;
            this.cpustart.Click += new System.EventHandler(this.cpustart_Click);
            // 
            // yingpantabPage2
            // 
            this.yingpantabPage2.BackColor = System.Drawing.Color.Transparent;
            this.yingpantabPage2.Controls.Add(this.yingpanstop);
            this.yingpantabPage2.Controls.Add(this.yingpanstart);
            this.yingpantabPage2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.yingpantabPage2.Location = new System.Drawing.Point(4, 22);
            this.yingpantabPage2.Name = "yingpantabPage2";
            this.yingpantabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.yingpantabPage2.Size = new System.Drawing.Size(326, 131);
            this.yingpantabPage2.TabIndex = 1;
            this.yingpantabPage2.Text = "I/O压力模拟";
            // 
            // yingpanstop
            // 
            this.yingpanstop.Cursor = System.Windows.Forms.Cursors.Default;
            this.yingpanstop.Location = new System.Drawing.Point(179, 57);
            this.yingpanstop.Name = "yingpanstop";
            this.yingpanstop.Size = new System.Drawing.Size(126, 23);
            this.yingpanstop.TabIndex = 1;
            this.yingpanstop.Text = "停止硬盘压力模拟";
            this.yingpanstop.UseVisualStyleBackColor = true;
            this.yingpanstop.Click += new System.EventHandler(this.yingpanstop_Click);
            // 
            // yingpanstart
            // 
            this.yingpanstart.Cursor = System.Windows.Forms.Cursors.Default;
            this.yingpanstart.Location = new System.Drawing.Point(8, 57);
            this.yingpanstart.Name = "yingpanstart";
            this.yingpanstart.Size = new System.Drawing.Size(115, 23);
            this.yingpanstart.TabIndex = 0;
            this.yingpanstart.Text = "开始硬盘压力模拟";
            this.yingpanstart.UseVisualStyleBackColor = true;
            this.yingpanstart.Click += new System.EventHandler(this.yingpanstart_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(334, 157);
            this.Controls.Add(this.cpu);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统压力测试小工具";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.cpu.ResumeLayout(false);
            this.tabcpu.ResumeLayout(false);
            this.yingpantabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TabPage tabcpu;
        private System.Windows.Forms.TabPage yingpantabPage2;
        private System.Diagnostics.Process process1;
        public System.Windows.Forms.TabControl cpu;
        public System.Windows.Forms.Button cpustop;
        public System.Windows.Forms.Button cpustart;
        public System.Windows.Forms.Button yingpanstop;
        public System.Windows.Forms.Button yingpanstart;
    }
}

