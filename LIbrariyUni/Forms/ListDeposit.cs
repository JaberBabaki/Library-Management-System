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
    public partial class ListDeposit : Master
    {
        public ListDeposit()
        {
            InitializeComponent();
        }

        private void ListDeposit_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Font = new Font("b yekan", 9);
        }
    }
}
