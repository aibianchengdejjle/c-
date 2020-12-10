using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFGames
{
    public partial class HitMForm : Form
    {
        public HitMForm()
        {
            InitializeComponent();
        }
        int n = 0;
        bool isHiting = true;
        //点击马老师事件
        private void HitClick_MouseDown(object sender, MouseEventArgs e)
        {
            if (isHiting != true)
            {
                return;
            }
            int i = (Convert.ToInt32((sender as Label).Name.Substring(5, 1)));
            switch (i)
            {
                case 1:
                    Mouse1.ImageIndex = 1;
                    break;
                case 2:
                    Mouse2.ImageIndex = 1;
                    break;
                case 3:
                    Mouse3.ImageIndex = 1;
                    break;
                case 4:
                    Mouse4.ImageIndex = 1;
                    break;
                case 5:
                    Mouse5.ImageIndex = 1;
                    break;
                case 6:
                    Mouse6.ImageIndex = 1;
                    break;
                case 7:
                    Mouse7.ImageIndex = 1;
                    break;
                case 8:
                    Mouse8.ImageIndex = 1;
                    break;
                case 9:
                    Mouse9.ImageIndex = 1;
                    break;
            }
            n += 1;
            txbScore.Text = n.ToString();
            isHiting = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            isHiting = true;
            Random random = new Random();
            switch (random.Next(1, 10))
            {
                case 1:
                    Mouse1.ImageIndex = 0;
                    Mouse1.Visible = true;
                    break;
                case 2:
                    Mouse2.ImageIndex = 0;
                    Mouse2.Visible = true;
                    break;
                case 3:
                    Mouse3.ImageIndex = 0;
                    Mouse3.Visible = true;
                    break;
                case 4:
                    Mouse4.ImageIndex = 0;
                    Mouse4.Visible = true;
                    break;
                case 5:
                    Mouse5.ImageIndex = 0;
                    Mouse5.Visible = true;
                    break;
                case 6:
                    Mouse6.ImageIndex = 0;
                    Mouse6.Visible = true;
                    break;
                case 7:
                    Mouse7.ImageIndex = 0;
                    Mouse7.Visible = true;
                    break;
                case 8:
                    Mouse8.ImageIndex = 0;
                    Mouse8.Visible = true;
                    break;
                case 9:
                    Mouse9.ImageIndex = 0;
                    Mouse9.Visible = true;
                    break;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Mouse1.Visible = false;
            Mouse2.Visible = false;
            Mouse3.Visible = false;
            Mouse4.Visible = false;
            Mouse5.Visible = false;
            Mouse6.Visible = false;
            Mouse7.Visible = false;
            Mouse8.Visible = false;
            Mouse9.Visible = false;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            n = 0;
            isHiting = true;
            timer1.Enabled = false;
            timer2.Enabled = false;
            timer3.Enabled = false;
            Mouse1.Visible = false;
            Mouse2.Visible = false;
            Mouse3.Visible = false;
            Mouse4.Visible = false;
            Mouse5.Visible = false;
            Mouse6.Visible = false;
            Mouse7.Visible = false;
            Mouse8.Visible = false;
            Mouse9.Visible = false;
            string xiaoxi = txbScore.Text;
            xiaoxi += "分，呵呵！";
            MessageBox.Show(xiaoxi, "Game Over!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            timer3.Enabled = true;
            timer4.Enabled = true;
        }

        private void 简单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            简单ToolStripMenuItem.Checked = true;
            中等ToolStripMenuItem.Checked = false;
            困难ToolStripMenuItem.Checked = false;
            timer1.Interval = 1200;
            timer2.Interval = 2400;
        }

        private void 中等ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            简单ToolStripMenuItem.Checked = false;
            中等ToolStripMenuItem.Checked = true;
            困难ToolStripMenuItem.Checked = false;
            timer1.Interval = 1000;
            timer2.Interval = 2000;
        }

        private void 困难ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            简单ToolStripMenuItem.Checked = false;
            中等ToolStripMenuItem.Checked = false;
            困难ToolStripMenuItem.Checked = true;
            timer1.Interval = 750;
            timer2.Interval = 1500;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMain formMain = new FormMain();
            formMain.Show();
        }

        private void 帮助ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string output = "可以选择3个难度";
            output += Environment.NewLine;
            output += "开始后点击即可与马老师对战";
            MessageBox.Show(output, "帮助", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        int time = 60;
        private void timer4_Tick(object sender, EventArgs e)
        {
            time--;
            lblTime.Text = time + "秒";
            if(time < 0)
            {
                lblTime.Text = 0 + "秒";
                timer4.Enabled = false;
                time = 60;
            }
        }
    }
}
