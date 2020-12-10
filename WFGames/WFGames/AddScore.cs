using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication.Enthernet.Redis;
using MySql.Data.MySqlClient;
using HslCommunication;

namespace WFGames
{
    public partial class AddScore : Form
    {
        public AddScore()
        {
            InitializeComponent();
        }
        RedisClient redisClient = new RedisClient("139.224.216.12", 7388, "");
        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String cno = textBox2.Text;
            String grade = textBox3.Text;
            //用户数据库插入
            String connStr = "Database=easyproject;datasource=139.224.216.12;port=3306;user=root;pwd=1234;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            String sql = "insert into grade values('" + id+ "','" + cno + "','" + grade + "')";
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            redisClient.WriteKey(new string[] { "id"+id, "cno"+cno, id+cno}, new string[] { id, cno,grade });
            MessageBox.Show("成功");
        }
    }
}
