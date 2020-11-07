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
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void Master_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel32.Visible = !panel32.Visible;
            if (panel32.Visible)
            {
                label1.Location = new Point(100, 10);
                panel30.Location = new Point(420, 0);
                pictureBox10.Location = new Point(450, 10);
            }
            else
            {
                //
                label1.Location = new Point(288, 14);
                pictureBox10.Location = new Point(732, 7);
                panel30.Location = new Point(718, 0);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
