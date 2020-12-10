using MySql.Data.MySqlClient;
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
    public partial class SelectById : Form
    {
        public SelectById()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connStr = "Database=easyproject;datasource=139.224.216.12;port=3306;user=root;pwd=1234;";
            MySqlConnection conn = new MySqlConnection(connStr);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("select * from easyuser ", conn);
            //执行命令读取数据
            MySqlDataReader reader = cmd.ExecuteReader();
            //
            while (reader.Read()) {
                string username = reader.GetString("username");
                string password = reader.GetString("password");
                MessageBox.Show(username + ":" + password);
            }
            reader.Close();
            conn.Close();
        }
    }
}
