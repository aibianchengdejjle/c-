using HslCommunication.Enthernet.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using HslCommunication;

namespace WFGames
{
    public partial class UpdateScore : Form
    {
        public UpdateScore()
        {
            InitializeComponent();
        }
        RedisClient redisClient = new RedisClient("139.224.216.12", 7385, "");
        Boolean flag = false;
        private void button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            String b = textBox2.Text;
            //MessageBox.Show(a + b);
            //使用自己定义的布隆过滤器 定义布隆过滤器的大小
            BloomFilter<String> bf = new BloomFilter<string>(20, 3);
            bf.Add("testing");
            bf.Add("nottesting");
            bf.Add("testingagain");
            bf.Add("admin006");
            List<string> testItems = new List<string>() { "badstring", "testing", "test" };
            if (!bf.Contains(a))
            {
                //数据库连接
                String connStr = "Database=easyproject;datasource=139.224.216.12;port=3306;user=root;pwd=1234;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                String sql = "select *  from easyuser where username='" + a + "'" + " and  `password` ='" + b + "'";
               // MessageBox.Show(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                //执行命令读取数据
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == false)
                {
                    MessageBox.Show("您输入的信息有误");
                }
                else {
                    flag = true;
                    String password=reader.GetString("password");
                    MessageBox.Show("Mysql数据库"+password);                                       
                    reader.Close();
                    conn.Close();
                }                               
            }
            else
            {  //布隆过滤器当中存在值  才会从缓存中查询
                RedisClient redisClient = new RedisClient("139.224.216.12", 7385, "");
                OperateResult<string> read = redisClient.ReadKey(a);
                MessageBox.Show("redis缓存"+read.Content);                                
                this.Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                //开始更改
                RedisClient redisClient88 = new RedisClient("139.224.216.12", 7388, "");
                String a = textBox1.Text;
                String b = textBox2.Text;
                String c = textBox3.Text;
                String connStr = "Database=easyproject;datasource=139.224.216.12;port=3306;user=root;pwd=1234;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                String sql = "update easyuser set password='" + c+ "' where username='" + a + "'" + " and  password ='" + b + "'";
                MessageBox.Show(sql);
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                //MessageBox.Show(flag.ToString());
                MessageBox.Show("修改成功");
                reader.Close();
                conn.Close();
                //保证一致性 缓存也要更改
                OperateResult<string> read = redisClient88.ReadKey(a);
                if (read.IsSuccess)
                {
                    //先删除再写入 
                    redisClient88.DeleteKey(a);
                    redisClient88.WriteKey(a, c);
                    MessageBox.Show("修改成功");
                }
                //缓存中无
                else
                {
                    //写入
                    redisClient88.WriteKey(a, c);
                    MessageBox.Show("写入成功");
                }
            }
            else {
                MessageBox.Show("数据库中暂无该内容");
            }
          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
