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
    public partial class Membership : Master
    {
        public Membership()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "فرم عضویت";
            pic.Image =Image.FromFile (@"C:\Users\User\Desktop\library\pers.png");
            pic.Tag =G.DEFAULT_PIC_USER;
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Calender cl = new Calender();
            DateTime d1 = DateTime.Now;
            string dateShamse = cl.MilliTimeStamp(d1);

            int m = each(1);
            if (m == 10)
            {
                Users users = new Users();
                users.numberStudent = Convert.ToDouble(txtNumberStudent.Text);
                users.name = txtName.Text;
                users.family = txtFamily.Text;
                users.mobile = txtPhone.Text;
                users.codeMeli = txtCodeMeli.Text;
                users.certificate = txtCertificate.Text;
                users.born = txtBorn.Text;
                users.fieldStudy = txtField.Text;
                users.email = txtEmail.Text;
                users.adress = txtAddress.Text;
                users.picture = pic.Tag.ToString();
                users.date = dateShamse;
                int i = users.insert();
                if (i == 1)
                {
                    MessageBox.Show("با موفقیت ثبت شد ");
                    each(2);
                    pic.Image = Image.FromFile(@"C:\Users\User\Desktop\library\pers.png");
                    pic.Tag = G.DEFAULT_PIC_USER;
                }
                else
                {
                    MessageBox.Show(" خطا در ثبت ");
                }
            }
            else
            {
                MessageBox.Show("لطفا اطلاعات را کامل وارد کنید ","هشدار");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {


        }

        private void pic_Click(object sender, EventArgs e)
        {
            string filePath = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.InitialDirectory = @"C:\Users\User\Pictures";
            dialog.Title = "Please select an image file .";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                filePath = dialog.FileName;
                //label8.Visible = false;
                pic.Image = Image.FromFile(filePath);
                pic.Tag = filePath;
            }


        }

        private int each( int i)
        {

            int m = 0;

            foreach (Control control in panel2.Controls)
            {
                foreach (Control grandChild in control.Controls)
                {
                    foreach (Control grandChild2 in grandChild.Controls)
                    {

                        if (grandChild2 is TextBox && grandChild2.Text != "")
                        {
                            if (i == 1)
                            {
                                m++;
                            }
                            else
                            {
                                grandChild2.Text = "";
                            }

                        }

                    }
                }
                
            }
            return m;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            each(2);
            pic.Image = Image.FromFile(@"C:\Users\User\Desktop\library\pers.png");
            pic.Tag = G.DEFAULT_PIC_USER;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
