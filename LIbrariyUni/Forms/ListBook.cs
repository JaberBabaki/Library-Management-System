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
    public partial class ListBook : Master
    {
        public ListBook()
        {
            InitializeComponent();
        }
        public static List<Input> inpu;
        List<double> authorsId = new List<double>();
        double publicId=0;
       List<string>  authorsName= new List<string>() ;
        private void ListBook_Load(object sender, EventArgs e)
        {
            inpu = new List<Input>();
            Books books = new Books();
            inpu = books.selected();
            int currentX = 20, currentY = 5;
            // MessageBox.Show(inpu.Count()+"");
            for (int i = 0; i <= inpu.Count() - 1; i++)
            {
                ListOfData lsd = new ListOfData();
                lsd.namee = inpu[i].Title;
                Authors authors = new Authors();
               // MessageBox.Show(inpu[i].Isbn + "");
                authorsId =  authors.selectedAuthorId(inpu[i].Isbn);
                if (authorsId.Count() != 0)
                {
                    for (int c = 0; c <= authorsId.Count() - 1; c++)
                    {
                        
                        authorsName.Add(authors.selectedAuthorName(authorsId[c]));
                        //MessageBox.Show("m " + authorsId[c] + "   authorsId[c]  " + authorsName[c]+"  authorsName[c]");
                        inpu[i].Name = inpu[i].Name + "|" + authorsName[c];
                    }
                    lsd.family = "..."+authorsName[0];
                }
                
                
               // MessageBox.Show(inpu[i].Name + "");
                Publications publications = new Publications();
                publicId = publications.selectedpublicationsId(inpu[i].Isbn);
                inpu[i].Family = publications.selectedpublicationName(publicId);
                lsd.code = inpu[i].Family;
                lsd.number = inpu[i].Isbn;
                lsd.btnTagDelete = inpu[i].Isbn+"*";
                lsd.btnTagDetails = i;
                authorsName.Clear();
                if (i % 2 == 0)
                {
                    lsd.colour = "#EDF0FC";
                }
                else
                {
                    lsd.colour = "#ffffff";
                }
                lsd.Location = new Point(currentX, currentY);
                this.panel5.Controls.Add(lsd);
                currentY = currentY + 50;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
