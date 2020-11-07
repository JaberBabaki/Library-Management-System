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
    public partial class ListMS : Master
    {
        
        public ListMS()
        {
            InitializeComponent();
        }
        public static List<Input> inpu;

        private void Form1_Load(object sender, EventArgs e)
        {
            inpu = new List<Input>();
            Users users = new Users();            
            inpu= users.selected();
            int currentX = 20, currentY = 5;
           // MessageBox.Show(inpu.Count()+"");
            for (int i = 0; i <= inpu.Count() - 1;i++ )
            {
                ListOfData lsd = new ListOfData();
                lsd.namee = inpu[i].Name;
                lsd.family = inpu[i].Family;
                lsd.code = inpu[i].NumberStudent.ToString();
                lsd.number = inpu[i].Mobile;
                lsd.btnTagDelete =inpu[i].NumberStudent.ToString();
                lsd.btnTagDetails = i;
                if (i % 2 == 0)
                {
                    lsd.colour = "#EDF0FC";
                }
                else
                {
                    lsd.colour = "#ffffff";
                }
                lsd.Location = new Point(currentX, currentY);
                this.panel2.Controls.Add(lsd);
                currentY = currentY + 50;
            }


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
