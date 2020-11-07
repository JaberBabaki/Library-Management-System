using LIbrariyUni.Cc;
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
    public partial class RecordBook : Master
    {
        public Boolean check;
        public static List<int> A_id = new List<int>();
        public int P_id =0;
        public static TextBox focusedTextbox = null;
        choice frm1;
        public RecordBook()
        {
            InitializeComponent();

        }
        void textBox_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
        }
        private void RecordBook_Load(object sender, EventArgs e)
        {
            //label1.Text = "فرم عضویت";
            pic.Image = Image.FromFile(@"C:\Users\User\Desktop\library\bok.jpg");
            pic.Tag =G.DEFAULT_PIC_BOOK;
          //  panel20.Visible = false;
           // panel21.Visible = false;
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Calender cl = new Calender();
            DateTime d1 = DateTime.Now;
            string dateShamse = cl.MilliTimeStamp(d1);


            if (txtTitle.Text != "" && txtYear.Text != "" && txtNumber.Text != "" && txtIsbn.Text != "" && txtPublication.Text != "" && txtC.Text != "" && panel10 .Enabled)
            {
                Books books = new Books();
                books.isbn=txtIsbn.Text;
                books.title = txtTitle.Text;
                books.yearPublication = Convert.ToInt16(txtYear.Text);
                books.numberBook = Convert.ToInt16(txtNumber.Text);
                books.picture = pic.Tag.ToString();
                books.date = dateShamse;
                int i= books.insert();
                for (int c = 0; c < A_id.Count() ; c++)
                {
                        Authors authors = new Authors();
                        authors.insertToBook_Writtenby(A_id[c], txtIsbn.Text);
                    
                
                }
                A_id.Clear();
                Publications publications = new Publications();
                publications.insertToBooks_published(P_id, txtIsbn.Text);
                if (i == 1)
                {
                    MessageBox.Show("با موفقیت ثبت شد ");
                    //each(2);
                }
                else
                {
                    MessageBox.Show(" خطا در ثبت ");
                }
            }
            else
            {
                MessageBox.Show("لطفا اطلاعات را کامل وارد کنید ", "هشدار");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

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
                pic.Image = Image.FromFile(filePath);
                pic.Tag = filePath;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            txtTitle.Text = "" ;
            txtYear.Text = "" ;
            txtNumber.Text = "" ;
            txtIsbn.Text = "";
             txtPublication.Text = "";
             txtC.Text = "";
             panel10 .Enabled=false;
             pic.Image = Image.FromFile(@"C:\Users\User\Desktop\library\bok.jpg");
             pic.Tag =G.DEFAULT_PIC_BOOK;
             txtC.Enabled = true;

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ch2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void che3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void che1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void che1_Click(object sender, EventArgs e)
        {

        }

        private void che3_Click(object sender, EventArgs e)
        {

        }

        private void che2_Click(object sender, EventArgs e)
        {

               
            
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel16_Enter(object sender, EventArgs e)
        {

        }

        private void txtC_KeyPress(object sender, KeyPressEventArgs e)
        {
            string str = txtC.Text;
            if (e.KeyChar ==(char) Keys.Enter)
            {

                panel10.Enabled = true;
                int i = 0;
                int currentX = 0;

                int currentY = 40;
                if (txtC.Text != "")
                {
                    i = Convert.ToInt16(txtC.Text);
                    for (int o = 1; o <= i; o++)
                    {
                        UserControl1 usc1 = new UserControl1();
                        usc1.Location = new Point(currentX, currentY);
                        panel16.Controls.Add(usc1);
                        currentY = currentY + 40;
                    }
                }

                txtC.Enabled = false;
                txtC.Text = str;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choice frm1 = new choice();
            frm1.event_method += new choice.delegate_method(get_nevisande_entesharat);
           
            frm1.Show();
        }
        private void get_nevisande_entesharat(string name, string family, int id, bool n_e)
        {
            if (n_e == false)
            {
                if (focusedTextbox != null)
                {

                    focusedTextbox.Text = family + " " + name;
                }
                if (id > 0)
                {
                    A_id.Add(id);
                }

            }
            else
            {
               txtPublication.Text = name;
                P_id = id;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             frm1 = new choice();
            frm1.n_e = true;
            reset_form();
            frm1.event_method += new choice.delegate_method(get_nevisande_entesharat);
            

            frm1.Show();

            

        }
        public void reset_form()
        {
            
            frm1.Text = "انتخاب انتشارات";
          //  frm1.l_nevisande.Visible = false;
           // sp.l_entesharat.Visible = true;
            frm1.groupBox1.Text = "ثبت انتشارات";
            frm1.c_nevisande_entesharat.Text = "ثبت انتشارات جدید";
            frm1.l_family.Visible = false;
            frm1.txtFamily.Visible = false;
            frm1.n_e = true;
           // sp.b_sabt.Location = new System.Drawing.Point(199, 27);
        } 
    }
}
