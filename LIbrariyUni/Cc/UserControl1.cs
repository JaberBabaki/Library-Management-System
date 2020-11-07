using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LIbrariyUni.Forms;

namespace LIbrariyUni.Cc
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            textBox6.Tag = 1;
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            RecordBook.focusedTextbox = (TextBox) sender;
        }
    }
}
