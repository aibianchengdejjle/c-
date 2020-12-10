using HslCommunication.Enthernet.Redis;
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
    public partial class DeleteScore : Form
    {
        public DeleteScore()
        {
            InitializeComponent();
        }
        RedisClient redisClient = new RedisClient("139.224.216.12", 7388, "");
        private void button1_Click(object sender, EventArgs e)
        {
            String cno = textBox1.Text;
            String project = textBox2.Text;
           // MessageBox.Show(id.ToString());
            String connStr = "Database=easyproject;datasource=139.224.216.12;port=3306;user=root;pwd=1234;";
            MySqlConnection conn = new MySqlConnection(connStr);
            String sql = "delete  from easyuser where username='" + cno + "'"+ " and password ='" + project + "'";
            conn.Open();
            try
            {
                //先判断是否存在
                String SelectSql = "select * from easyuser where username='" + cno + "'";
                MySqlCommand selectcmd = new MySqlCommand(SelectSql, conn);
                MySqlDataReader reader= selectcmd.ExecuteReader();
                //如果存在在删除
                if (reader.Read())
                {
                     reader.Close();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                    //对缓存的值进行删除 实现一致性
                    redisClient.DeleteKey(cno);
                    MessageBox.Show("删除成功");
                }
                else {
                    MessageBox.Show("用户不存在");
                    reader.Close();
                }
                conn.Close();
            }
            catch (MySqlException ex){
                MessageBox.Show(ex.Message);
            }
        }
    }
}
