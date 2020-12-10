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
    public partial class SucessForm : Form
    {
        public SucessForm()
        {
            InitializeComponent();
        }

        private void LoginSucess_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteScore deleteScore = new DeleteScore();
            deleteScore.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddScore addScore = new AddScore();
            addScore.Show();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateScore updateScore = new UpdateScore();
            updateScore.Show();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SelectById selectById = new SelectById();
            selectById.Show();
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SelectByCno selectByCno = new SelectByCno();
            selectByCno.Show();
            
        }
    }
}
