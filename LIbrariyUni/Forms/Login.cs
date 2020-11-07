using LIbrariyUni.Src;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbrariyUni.Forms
{
    public partial class Login : Form
    {
        public List<Input> input =new  List<Input>();
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_Click_1(object sender, EventArgs e)
        {


        }

        private void radioButton2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("" + input.Count());
            if (comboBox1.SelectedIndex == 0)
            {
                Users users = new Users();
                users.numberStudent = Convert.ToDouble( textBox2.Text);
                input= users.login();
               // MessageBox.Show("" + input.Count());
                if (input[0].Email==textBox1 .Text )
                {
                    MessageBox.Show(input[0].Name+"  "+" عزیز به برنامه خوش آمدید");
                    G.IDENTITY = 1;
                    Master.label2.Text = input[0].Name;
                    Master.label4.Text="کاربر" ;
                   // Main.panel31.Enabled = true;
                   // Main.panel8.Enabled = true;
                   // Main.panel14.Enabled = true;


                }else{
                    MessageBox.Show("رمز عبور یا نام کاربری معتبر نمی باشد");
                }
            }
            else if (comboBox1.SelectedIndex == 1)
            {

            }
            else if (comboBox1.SelectedIndex == 2)
            {

            }
        }
    }
}
