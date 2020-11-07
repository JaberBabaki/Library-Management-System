using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIbrariyUni.Src;
using LIbrariyUni.Forms;

namespace LIbrariyUni.Cc
{
    public partial class ListOfData : UserControl
    {
        string a = "";
        private string Namee;
        private string    Family ;
        private string    Code ;
        private string    Number ;
        private string Colour;
        private string BtnTagDelete;
        private int BtnTagDetails;
        public ListOfData()
        {
            InitializeComponent();
        }
        public string namee
        {
            set { Namee = value; }
            get{return Namee;}
        }
        public string family
        {
            set { Family = value; }
            get { return Family; }
        }
        public string code
        {
            set { Code = value; }
            get { return Code; }
        }
        public string number
        {
            set { Number = value; }
            get { return Number; }
        }
        public string colour
        {
            set { Colour = value; }
            get { return Colour; }
        }
        public string btnTagDelete
        {
            set { BtnTagDelete = value; }
            get { return BtnTagDelete; }
        }
        public int btnTagDetails
        {
            set { BtnTagDetails = value; }
            get { return BtnTagDetails; }
        }
        
        private void Lname_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            
            //MessageBox.Show("ll" + namee);
            Color col = System.Drawing.ColorTranslator.FromHtml(colour);
            Lname.Text = namee;
            Lfamily.Text = family;
            Lcode.Text = code;
            Lnumber.Text = number;
            panel1.BackColor = col;
            Lname.Text = namee;
            button1.Tag = btnTagDelete;
            button2.Tag = btnTagDetails;
            button1.Click += new EventHandler(p13_MouseUp);
            button2.Click += new EventHandler(p14_MouseUp);
            a = button1.Tag.ToString().Substring((button1.Tag.ToString().Length - 1), 1);
        }

        private void p13_MouseUp(object sender, EventArgs e)
        {

            string b = button1.Tag.ToString().Substring(0, (button1.Tag.ToString().Length - 1));
            if (a.Equals("*"))
            {
                MessageBox.Show("آیااز حذف مطمئنید؟" + a);
                Books books = new Books();
                books.isbn = b;
                int i = books.deleted();
                if (i == 1)
                {
                    MessageBox.Show("کاربر مورد نظر حذف شد");
                }
                else
                {
                    MessageBox.Show("خطا در عملیات");
                }
            }
            else
            {
                MessageBox.Show("آیااز حذف مطمئنید؟" + a);
                Users users = new Users();
                users.numberStudent = Convert.ToDouble(button1.Tag);
                int i = users.deleted();
                if (i == 1)
                {
                    MessageBox.Show("کاربر مورد نظر حذف شد");
                }
                else
                {
                    MessageBox.Show("خطا در عملیات");
                }
            }
        }
        private void p14_MouseUp(object sender, EventArgs e)
        {
            if (a.Equals("*"))
            {
                ProfileBook profileBook = new ProfileBook();
                profileBook.Show();
            }
            else
            {
                Profile profile = new Profile(Convert.ToInt16(button2.Tag));
                profile.Show();
            }


        }
        private void Lnumber_Click(object sender, EventArgs e)
        {

        }

        private void Lfamily_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
