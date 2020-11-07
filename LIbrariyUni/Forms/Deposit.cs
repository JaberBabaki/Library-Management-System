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
    public partial class Deposit : Master 
    {
        public List<Input> input=new List<Input>() ;
        int repeat=0;
        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {
            Calender calender = new Calender();
            Calender cl = new Calender();
            DateTime d1 = DateTime.Now;
             txtTitle.Text = cl.MilliTimeStamp(d1);
            txtTitleGet.Text = cl.MilliTimeStamp(d1.AddDays(17));
       
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = txtNumber.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    Users users = new Users();
                    users.numberStudent = Convert.ToDouble(txtNumber.Text);
                    input = users.selectByNumberStudent();
                    pictureBox1.Image = Image.FromFile(input[0].Picture);
                    txtName.Text = input[0].Name;
                    txtFamily.Text = input[0].Family;
                    txtNumber.Text = "";
                    txtNumber.Text = str;
                }
                catch
                {
                    txtNumber.Text = "";
                    MessageBox.Show("کاربر مورد نظر یافت نشد");
                    
                }
            }

          
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = txtNumberBook.Text;
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    Books books = new Books();
                    books.isbn = txtNumberBook.Text;
                    input = books.selectByIsbn();

                    txtYear.Text = input[0].YearPublication.ToString();
                    txtT.Text = input[0].Title;
                    repeat = input[0].Repeat;
                    pictureBox7.Image = Image.FromFile(input[0].Picture);
                    txtNumberBook.Text = "";
                    txtNumberBook.Text = str;
                }
                catch
                {
                    txtNumberBook.Text = "";
                    MessageBox.Show("کتاب مورد نظر یافت نشد");
                    
                }
            }
        }

        private void txtNumberBook_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         if (txtNumberBook.Text != "" && txtNumber.Text != "" && txtTitle.Text != "" && txtTitleGet.Text != "" && txtYear.Text != "" && txtT.Text != "" && txtName.Text != "" && txtFamily.Text != "") { 
           Loan loan = new Loan();
           loan.isbn = txtNumberBook.Text;
           loan.numberStudent =Convert.ToDouble( txtNumber.Text);
           loan.dateDelivery = txtTitle.Text;
           loan.dateReturn = txtTitleGet.Text;
           loan.flag = 1;
           loan.year =Convert.ToInt16( txtYear.Text);
           loan.title=txtT.Text;
          // MessageBox.Show("" + txtYear.Text);
           loan.name = txtName.Text;
           loan.family = txtFamily.Text;
           int i=loan.insertLoan();
           if (i == 1)
           {
               MessageBox.Show("اطلاعات بدرستی  ثبت شد ");
               Books books = new Books();
               books.isbn = txtNumberBook.Text.Trim ();
               books.repeat = repeat+1;
               books.updaded();
           }
           restTXT();
        }else{
            MessageBox.Show("لطفا اطلاعات را کامل کنید ");
        }
        }
        public void restTXT()
        {
            txtNumberBook.Text = "";
            txtNumber.Text = "";
           // txtTitle.Text = "";
           // txtTitleGet.Text = "";
            txtYear.Text = "";
            txtT.Text = "";
            txtName.Text = "";
            txtFamily.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            restTXT();
        }
    }
}
