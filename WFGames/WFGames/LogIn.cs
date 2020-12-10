using HslCommunication;
using HslCommunication.Enthernet.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StackExchange.Redis;
using MySql.Data.MySqlClient;

namespace WFGames
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        private void NineCheckForm_Load(object sender, EventArgs e)
        {
          
        }
        RedisClient redisClient=new RedisClient("139.224.216.12",7383,"");
        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;
            //对于登录这种高并发的项目，要使用布隆过滤器
            BloomFilter<String> bf = new BloomFilter<string>(20,3);
            //bf.Add("admin");
            bf.Add("root");
            OperateResult<string> read=null;
            //如果不存在再去数据库查询
            if (!bf.Contains(username))
            {
                String connStr = "Database=easyproject;datasource=139.224.216.12;port=3306;user=root;pwd=1234;";
                MySqlConnection conn = new MySqlConnection(connStr);
                String sql = "select password from user where username='" + username + "'";
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //执行命令读取数据
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    String password1 = reader.GetString("password");
                    if (password1 ==password) {
                        SucessForm sucessForm2 = new SucessForm();
                        sucessForm2.Show();
                        reader.Close();
                        this.Hide();
                        this.Invalidate();
                    }
                    break;
                }
                 
            }
            
            else {
                //存在直接向缓存查找
                read = redisClient.ReadKey(username);
                if (password == read.Content){
                  SucessForm sucessForm = new SucessForm();
                  sucessForm.Show();
                  this.Hide();
                }else {
                     MessageBox.Show(read.Message);
                }
               
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
    }
}
