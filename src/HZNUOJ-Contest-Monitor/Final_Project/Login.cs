using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBoxEx1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //合法性判断
            if (ip.Text.Equals("") == false)
            {
                DBTool.server = ip.Text;
            }
            if (user_id.Text.Equals("") == false) 
            {
                DBTool.user_id = user_id.Text;
            }
            if (password.Text.Equals("") == false)
            {
                DBTool.password = password.Text;
            }
            if (contest_id.Text.Equals("") == false)
            {
                DBTool.contest_id = contest_id.Text;
            }
            if (DBTool.LogInTest() == false)  
            {
                MessageBox.Show("连接信息错误，连接失败！"); 
            } 
            else
            {
                this.DialogResult = DialogResult.OK; 
                this.Close();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
