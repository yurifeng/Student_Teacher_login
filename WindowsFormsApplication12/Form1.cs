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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false && radioButton2.Checked == true)
            {
                MessageBox.Show("您选择的是:  "+radioButton2.Text,"消息");
            }
            else if (radioButton1.Checked == true && radioButton2.Checked == false)
            {
                MessageBox.Show("您选择的是:  "+radioButton1.Text, "消息");
            }
            else
            {
                MessageBox.Show("没有选择性别,请选择!","提示!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;

        }
    }
}
