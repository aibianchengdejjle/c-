using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HslCommunication;
using HslCommunication.Enthernet.Redis;
using MySql.Data.MySqlClient;
using StackExchange.Redis;
namespace WFGames
{
    public partial class SelectByCno : Form
    {
        public SelectByCno()
        {
            InitializeComponent();
        }
        //连接集群用来读取
        RedisClient redisClient = new RedisClient("139.224.216.12", 7385, "");
        private void button1_Click(object sender, EventArgs e)
        {
            String a = textBox1.Text;
            //使用自己定义的布隆过滤器 定义布隆过滤器的大小
            BloomFilter<String> bf = new BloomFilter<string>(20,3);
            bf.Add("testing");
            bf.Add("nottesting");
            bf.Add("testingagain");
            //判断是否在存在
           // MessageBox.Show("bf.contains badstring"+bf.Contains("badstring").ToString());  //false
           // MessageBox.Show("bf.contains testing"+bf.Contains("testing").ToString());  //true
            //将一个链表 放置到布隆过滤器中
            List<string> testItems = new List<string>() { "badstring", "testing", "test" };
            //判断是否全部在
            // MessageBox.Show("bf.ContainsAll" + bf.ContainsAll(testItems).ToString());
            // 判断任意链表在
            //MessageBox.Show("bf.ContainsAny" + bf.ContainsAny(testItems).ToString());           
            // OperateResult<string> read=  redisClient.ReadKey(a);
            //说明查询的结果为false
            if (!bf.Contains(a)){
                //数据库连接
                String connStr = "Database=easyproject;datasource=139.224.216.12;port=3306;user=root;pwd=1234;";
                MySqlConnection conn = new MySqlConnection(connStr);
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("select * from easyuser ", conn);
                //执行命令读取数据
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read()){
                    string username = reader.GetString("username");
                    string password = reader.GetString("password");
                    //将数据库中的数据在返回到缓存中 存到主节点主节点才能写
                    RedisClient redisClient89 = new RedisClient("139.224.216.12", 7389, "");
                    redisClient89.WriteKey(new string[] { "id" + username, "cno" + password }, new string[] { username, password });
                    Label label = new Label();
                    label.Height = 40;
                    label.Width = flowLayoutPanel1.Width - 10;
                    label.Text = username + " : " + password;
                    flowLayoutPanel1.Controls.Add(label);
                    this.Invalidate();
                }
                reader.Close();
                conn.Close();
            }else {  //布隆过滤器当中存在值  才会从缓存中查询
                RedisClient redisClient = new RedisClient("139.224.216.12", 7385, "");
                OperateResult<string> read=redisClient.ReadKey("k1");
                MessageBox.Show(read.Content);
                Label label85 = new Label();
                label85.Text = read.Content;
                label85.Height = 40;
                label85.Width = flowLayoutPanel1.Width - 10;
                flowLayoutPanel1.Controls.Add(label85);
                this.Invalidate();
            }
        }
    }
}
