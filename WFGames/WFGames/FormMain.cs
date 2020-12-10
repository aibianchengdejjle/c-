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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            HitMForm hitMouseForm = new HitMForm();
            this.Hide();
            hitMouseForm.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LogIn nineCheckForm = new LogIn();
            this.Hide();
            nineCheckForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            HitMForm hitMouseForm = new HitMForm();
            this.Hide();
            hitMouseForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            LogIn nineCheckForm = new LogIn();
            this.Hide();
            nineCheckForm.Show();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            pictureBox1.SendToBack();
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            label1.BringToFront();
        }
    }
}
