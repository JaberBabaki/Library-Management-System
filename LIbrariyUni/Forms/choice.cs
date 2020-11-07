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
    public partial class choice : Form
    {
        public delegate void delegate_method(string name, string family, int id, bool n_e);
        public event delegate_method event_method;
        string name = "", familly = "";
        int A_ID = -1, P_ID = -1;
        public bool n_e = false;
        private Boolean WichFill=true;
        public Boolean wichFill
        {
            set { WichFill = value; }
            get { return WichFill; }
        }
        public choice()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (n_e==false)
            {
                fill_datagridview_nevisande_select();
            }
            else
            {
                fill_datagridview_entesharat_select();
            }
        }

        private void c_nevisande_entesharat_Click(object sender, EventArgs e)
        {
            if (c_nevisande_entesharat.Checked == true)
                groupBox1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (n_e == false)
            {
                string name = txtName.Text;
                string family = txtFamily.Text;
                Authors authores = new Authors();
                authores.name = txtName.Text;
                authores.family = txtFamily.Text;
                authores.insert();
                fill_datagridview_nevisande_select();


            }
            else
            {

                Publications publications = new Publications();
                publications.name = txtName.Text;
                publications.insert();
                fill_datagridview_entesharat_select();
            }
        }
        public void fill_datagridview_nevisande_select(){
                        Authors authores = new Authors();
                dgv1.DataSource=authores.selectAll();
                dgv1.Columns["author_id"].HeaderText = "شماره ";
                dgv1.Columns["name"].HeaderText = " نام";
                dgv1.Columns["family"].HeaderText = "نام خانوادگی";
                dgv1.Columns["author_id"].Width = 70;
                dgv1.Columns["name"].Width = 80;
                dgv1.Columns["family"].Width = 100;
         }
        public void fill_datagridview_entesharat_select()
        {
            Publications publications = new Publications();
            dgv1.DataSource = publications.selectAll();
            dgv1.Columns["public_id"].HeaderText = "شماره انتشارات";
            dgv1.Columns["name"].HeaderText = " نام انتشارات";
            dgv1.Columns["public_id"].Width = 100;
            dgv1.Columns["name"].Width = 200;
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (n_e == false)
                {
                    A_ID = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["author_id"].Value.ToString());
                    name = dgv1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                    familly = dgv1.Rows[e.RowIndex].Cells["family"].Value.ToString();
                }
                else
                {
                    P_ID = Convert.ToInt32(dgv1.Rows[e.RowIndex].Cells["public_id"].Value.ToString());
                    name = dgv1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.OpenForms["RecordBook"].Activate();
            if (n_e == false)
                event_method.Invoke(name, familly, A_ID, n_e);
            else
                event_method.Invoke(name, "", P_ID, n_e);


            Application.OpenForms["RecordBook"].Enabled = true;
            this.Close();
        }
    }
}
