namespace WFGames
{
    partial class HitMForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HitMForm));
            this.MenuStripGame = new System.Windows.Forms.MenuStrip();
            this.游戏难度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.简单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.中等ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.困难ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.其他ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Mouse1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Mouse2 = new System.Windows.Forms.Label();
            this.Mouse3 = new System.Windows.Forms.Label();
            this.Mouse4 = new System.Windows.Forms.Label();
            this.Mouse5 = new System.Windows.Forms.Label();
            this.Mouse6 = new System.Windows.Forms.Label();
            this.Mouse9 = new System.Windows.Forms.Label();
            this.Mouse8 = new System.Windows.Forms.Label();
            this.Mouse7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Label();
            this.txbScore = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblT = new System.Windows.Forms.Label();
            this.MenuStripGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStripGame
            // 
            this.MenuStripGame.AutoSize = false;
            this.MenuStripGame.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStripGame.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏难度ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.其他ToolStripMenuItem});
            this.MenuStripGame.Location = new System.Drawing.Point(0, 0);
            this.MenuStripGame.Name = "MenuStripGame";
            this.MenuStripGame.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.MenuStripGame.Size = new System.Drawing.Size(679, 35);
            this.MenuStripGame.TabIndex = 0;
            this.MenuStripGame.Text = "menuStrip1";
            // 
            // 游戏难度ToolStripMenuItem
            // 
            this.游戏难度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.简单ToolStripMenuItem,
            this.中等ToolStripMenuItem,
            this.困难ToolStripMenuItem});
            this.游戏难度ToolStripMenuItem.Name = "游戏难度ToolStripMenuItem";
            this.游戏难度ToolStripMenuItem.Size = new System.Drawing.Size(68, 31);
            this.游戏难度ToolStripMenuItem.Text = "游戏难度";
            // 
            // 简单ToolStripMenuItem
            // 
            this.简单ToolStripMenuItem.Checked = true;
            this.简单ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.简单ToolStripMenuItem.Name = "简单ToolStripMenuItem";
            this.简单ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.简单ToolStripMenuItem.Text = "简单";
            this.简单ToolStripMenuItem.Click += new System.EventHandler(this.简单ToolStripMenuItem_Click);
            // 
            // 中等ToolStripMenuItem
            // 
            this.中等ToolStripMenuItem.Name = "中等ToolStripMenuItem";
            this.中等ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.中等ToolStripMenuItem.Text = "中等";
            this.中等ToolStripMenuItem.Click += new System.EventHandler(this.中等ToolStripMenuItem_Click);
            // 
            // 困难ToolStripMenuItem
            // 
            this.困难ToolStripMenuItem.Name = "困难ToolStripMenuItem";
            this.困难ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.困难ToolStripMenuItem.Text = "困难";
            this.困难ToolStripMenuItem.Click += new System.EventHandler(this.困难ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(44, 31);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 其他ToolStripMenuItem
            // 
            this.其他ToolStripMenuItem.Name = "其他ToolStripMenuItem";
            this.其他ToolStripMenuItem.Size = new System.Drawing.Size(44, 31);
            this.其他ToolStripMenuItem.Text = "帮助";
            this.其他ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem1_Click);
            // 
            // Mouse1
            // 
            this.Mouse1.BackColor = System.Drawing.Color.Transparent;
            this.Mouse1.ImageIndex = 0;
            this.Mouse1.ImageList = this.imageList1;
            this.Mouse1.Location = new System.Drawing.Point(18, 88);
            this.Mouse1.Name = "Mouse1";
            this.Mouse1.Size = new System.Drawing.Size(120, 135);
            this.Mouse1.TabIndex = 2;
            this.Mouse1.Visible = false;
            this.Mouse1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HitClick_MouseDown);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "_Hit.png");
            this.imageList1.Images.SetKeyName(1, "Hit.png");
            // 
            // timer1
            // 
            this.timer1.Interval = 1200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 2400;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 60000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Mouse2
            // 
            this.Mouse2.BackColor = System.Drawing.Color.Transparent;
            this.Mouse2.ImageIndex = 0;
            this.Mouse2.ImageList = this.imageList1;
            this.Mouse2.Location = new System.Drawing.Point(193, 88);
            this.Mouse2.Name = "Mouse2";
            this.Mouse2.Size = new System.Drawing.Size(120, 135);
            this.Mouse2.TabIndex = 2;
            this.Mouse2.Visible = false;
            this.Mouse2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HitClick_MouseDown);
            // 
            // Mouse3
            // 
            this.Mouse3.BackColor = System.Drawing.Color.Transparent;
            this.Mouse3.ImageIndex = 0;
            this.Mouse3.ImageList = this.imageList1;
            this.Mouse3.Location = new System.Drawing.Point(362, 88);
            this.Mouse3.Name = "Mouse3";
            this.Mouse3.Size = new System.Drawing.Size(120, 135);
            this.Mouse3.TabIndex = 2;
            this.Mouse3.Visible = false;
            this.Mouse3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HitClick_MouseDown);
            // 
            // Mouse4
            // 
            this.Mouse4.BackColor = System.Drawing.Color.Transparent;
            this.Mouse4.ImageIndex = 0;
            this.Mouse4.ImageList = this.imageList1;
            this.Mouse4.Location = new System.Drawing.Point(18, 293);
            this.Mouse4.Name = "Mouse4";
            this.Mouse4.Size = new System.Drawing.Size(120, 135);
            this.Mouse4.TabIndex = 2;
            this.Mouse4.Visible = false;
            this.Mouse4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HitClick_MouseDown);
            // 
            // Mouse5
            // 
            this.Mouse5.BackColor = System.Drawing.Color.Transparent;
            this.Mouse5.ImageIndex = 0;
            this.Mouse5.ImageList = this.imageList1;
            this.Mouse5.Location = new System.Drawing.Point(193, 293);
            this.Mouse5.Name = "Mouse5";
            this.Mouse5.Size = new System.Drawing.Size(120, 135);
            this.Mouse5.TabIndex = 2;
            this.Mouse5.Visible = false;
            this.Mouse5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HitClick_MouseDown);
            // 
            // Mouse6
            // 
            this.Mouse6.BackColor = System.Drawing.Color.Transparent;
            this.Mouse6.ImageIndex = 0;
            this.Mouse6.ImageList = this.imageList1;
            this.Mouse6.Location = new System.Drawing.Point(362, 293);
            this.Mouse6.Name = "Mouse6";
            this.Mouse6.Size = new System.Drawing.Size(120, 135);
            this.Mouse6.TabIndex = 2;
            this.Mouse6.Visible = false;
            this.Mouse6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HitClick_MouseDown);
            // 
            // Mouse9
            // 
            this.Mouse9.BackColor = System.Drawing.Color.Transparent;
            this.Mouse9.ImageIndex = 0;
            this.Mouse9.ImageList = this.imageList1;
            this.Mouse9.Location = new System.Drawing.Point(362, 501);
            this.Mouse9.Name = "Mouse9";
            this.Mouse9.Size = new System.Drawing.Size(120, 135);
            this.Mouse9.TabIndex = 2;
            this.Mouse9.Visible = false;
            this.Mouse9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HitClick_MouseDown);
            // 
            // Mouse8
            // 
            this.Mouse8.BackColor = System.Drawing.Color.Transparent;
            this.Mouse8.ImageIndex = 0;
            this.Mouse8.ImageList = this.imageList1;
            this.Mouse8.Location = new System.Drawing.Point(193, 501);
            this.Mouse8.Name = "Mouse8";
            this.Mouse8.Size = new System.Drawing.Size(120, 135);
            this.Mouse8.TabIndex = 2;
            this.Mouse8.Visible = false;
            this.Mouse8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HitClick_MouseDown);
            // 
            // Mouse7
            // 
            this.Mouse7.BackColor = System.Drawing.Color.Transparent;
            this.Mouse7.ImageIndex = 0;
            this.Mouse7.ImageList = this.imageList1;
            this.Mouse7.Location = new System.Drawing.Point(18, 501);
            this.Mouse7.Name = "Mouse7";
            this.Mouse7.Size = new System.Drawing.Size(120, 135);
            this.Mouse7.TabIndex = 2;
            this.Mouse7.Visible = false;
            this.Mouse7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HitClick_MouseDown);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("华文隶书", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(609, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 46);
            this.label10.TabIndex = 14;
            this.label10.Text = "分";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer4
            // 
            this.timer4.Interval = 1000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("华文隶书", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(546, 60);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(118, 48);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "开始";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txbScore
            // 
            this.txbScore.AutoSize = true;
            this.txbScore.BackColor = System.Drawing.Color.Transparent;
            this.txbScore.Font = new System.Drawing.Font("华文隶书", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txbScore.Location = new System.Drawing.Point(550, 265);
            this.txbScore.Name = "txbScore";
            this.txbScore.Size = new System.Drawing.Size(42, 48);
            this.txbScore.TabIndex = 16;
            this.txbScore.Text = "0";
            this.txbScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txbScore.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("华文隶书", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.Location = new System.Drawing.Point(574, 499);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 30);
            this.lblTime.TabIndex = 16;
            this.lblTime.Text = "0秒";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTime.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.BackColor = System.Drawing.Color.Transparent;
            this.lblT.Font = new System.Drawing.Font("华文隶书", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblT.Location = new System.Drawing.Point(549, 473);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(103, 30);
            this.lblT.TabIndex = 16;
            this.lblT.Text = "倒计时";
            this.lblT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblT.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // HitMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(679, 656);
            this.Controls.Add(this.txbScore);
            this.Controls.Add(this.lblT);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Mouse7);
            this.Controls.Add(this.Mouse4);
            this.Controls.Add(this.Mouse8);
            this.Controls.Add(this.Mouse5);
            this.Controls.Add(this.Mouse9);
            this.Controls.Add(this.Mouse6);
            this.Controls.Add(this.Mouse3);
            this.Controls.Add(this.Mouse2);
            this.Controls.Add(this.Mouse1);
            this.Controls.Add(this.MenuStripGame);
            this.MainMenuStrip = this.MenuStripGame;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HitMForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "马老师大作战";
            this.MenuStripGame.ResumeLayout(false);
            this.MenuStripGame.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStripGame;
        private System.Windows.Forms.ToolStripMenuItem 游戏难度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 简单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 中等ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 困难ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 其他ToolStripMenuItem;
        private System.Windows.Forms.Label Mouse1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label Mouse2;
        private System.Windows.Forms.Label Mouse3;
        private System.Windows.Forms.Label Mouse4;
        private System.Windows.Forms.Label Mouse5;
        private System.Windows.Forms.Label Mouse6;
        private System.Windows.Forms.Label Mouse9;
        private System.Windows.Forms.Label Mouse8;
        private System.Windows.Forms.Label Mouse7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Label btnStart;
        private System.Windows.Forms.Label txbScore;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblT;
    }
}