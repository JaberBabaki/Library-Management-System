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
    public partial class Profile : Form
    {
        private int Indicator;
        public int indicator
        {
            set { Indicator = value; }
            get { return Indicator; }
        }
        public Profile(int i)
        {
            indicator = i;
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Profile_Load(object sender, EventArgs e)
        {
            
            Lname.Text = ListMS.inpu[indicator].Name;
            Lfamily.Text = ListMS.inpu[indicator].Family;
            Lnumber.Text = ListMS.inpu[indicator].NumberStudent.ToString();
            Lphone.Text = ListMS.inpu[indicator].Mobile;
            Lcode.Text = ListMS.inpu[indicator].CodeMeli;
            Lidentical.Text = ListMS.inpu[indicator].Certificate;
            Lborn.Text = ListMS.inpu[indicator].Born;
            Lemail.Text = ListMS.inpu[indicator].Email;
            Ltahseli.Text = ListMS.inpu[indicator].FieldStudy;
            Laddress.Text = ListMS.inpu[indicator].Adress;
            pictureBox7.Image = Image.FromFile(ListMS.inpu[indicator].Picture);
            pictureBox7.Tag = ListMS.inpu[indicator].Picture.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + indicator);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            each();

            if (button3.Text.Equals("تایید"))
            {

                button3.Text = "ویرایش";
                Users users = new Users();
                users.numberStudent = Convert.ToDouble(Lnumber.Text);
                users.name = Lname.Text;
                users.family = Lfamily.Text;
                users.mobile = Lphone.Text;
                users.codeMeli = Lcode.Text;
                users.certificate = Lidentical.Text;
                users.born = Lborn.Text;
                users.fieldStudy = Ltahseli.Text;
                users.email = Lemail.Text;
                users.adress = Laddress.Text;
                users.picture = pictureBox7.Tag.ToString();
                 users.id= (int)ListMS.inpu[indicator].id;
               // MessageBox.Show(""+m);
                int i= users.updated();
                if (i == 1)
                {
                    MessageBox.Show("ویرایش با موفقیت انجام شد");
                }
                else {
                    MessageBox.Show("خطا در عملیات"); 
                }

            }
            else
            {
                button3.Text = "تایید";
            }
            
        }
        private void each()
        {


            foreach (Control control in this.Controls)
            {


                if (control is TextBox)
                {
                    if (control.Name!="Lnumber")
                    control.Enabled = !control.Enabled;

                }


            }

        }

        private void pictureBox7_Click(object sender, EventArgs e)
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
                pictureBox7.Image = Image.FromFile(filePath);
                pictureBox7.Tag = filePath;
            }
        }
    }
}
