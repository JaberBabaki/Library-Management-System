using LIbrariyUni.Forms;
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

namespace LIbrariyUni
{
    public partial class Main : Master
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //anel32.Visible = !panel32.Visible;
        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
            //panel2.Cursor = new Cursor(@"C:\WINDOWS\Cursors\cross_im.cur");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel27_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void panel27_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button1.Enabled == false)
            {
                MessageBox.Show("لطفا جهت اهزاز هویت ورد بفرمایید");
            }
            Membership mbs = new Membership();
            mbs.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListMS lms = new ListMS();
            lms.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RecordBook rbk = new RecordBook();
            rbk.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ListBook lsb = new ListBook();
            lsb.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Deposit des = new Deposit();
            des.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ListDeposit ldep = new ListDeposit();
            ldep.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AdvanceSearch search = new AdvanceSearch();
            search.Show();
        }

        private void Main_Activated(object sender, EventArgs e)
        {
            if (G.IDENTITY == 1)
            {
                panel31.Enabled = true;
                panel8.Enabled = true;
                panel14.Enabled = true;
                
            }
        }

        private void panel32_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

    }
}
