using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 用户登录系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string pwd = textBox2.Text;
            if (radioButton1.Checked)
            {
                if (username == "jsd" && pwd == "jsd")
                {
                    MessageBox.Show("学生登录成功...", "消息");
                }
                else
                {
                    MessageBox.Show("用户名或者密码错误!!", "消息");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            else if (radioButton2.Checked)
            {
                if (username == "yuri" && pwd == "yuri")
                {
                    MessageBox.Show("教师登陆成功...", "消息");
                }
                else
                {
                    MessageBox.Show("用户名或者密码错误!!", "消息");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show("请选择登录的身份!!", "警告!!");
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        /// <summary>
        /// 重置按钮,重置所有的输入内容以及单选框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }
    }
}