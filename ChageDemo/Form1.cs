using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChageDemo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //用户名
        public static string uName = "chenhui";
        //密码
        public static string passWorld = "123456";

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.8;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            string pwd = textBox2.Text.Trim();
            if (userName.Equals(uName))
            {
                if (passWorld.Equals(pwd))
                {
                    MessageBox.Show("登录成功!欢迎你!" + uName);
                    this.Hide();
                }
                else {
                    MessageBox.Show("密码不正确!");
                }
            }
            else {
                MessageBox.Show("用户名不正确!");
            }
        }
    }
}
