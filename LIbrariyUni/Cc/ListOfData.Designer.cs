namespace LIbrariyUni.Cc
{
    partial class ListOfData
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Lnumber = new System.Windows.Forms.Label();
            this.Lcode = new System.Windows.Forms.Label();
            this.Lfamily = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Lnumber);
            this.panel1.Controls.Add(this.Lcode);
            this.panel1.Controls.Add(this.Lfamily);
            this.panel1.Controls.Add(this.Lname);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 45);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(126)))), ((int)(((byte)(214)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("B Yekan", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(82, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 46);
            this.button2.TabIndex = 11;
            this.button2.Text = "جزیئات";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(149)))), ((int)(((byte)(28)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("B Yekan", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 46);
            this.button1.TabIndex = 10;
            this.button1.Text = "حذف";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lnumber
            // 
            this.Lnumber.Font = new System.Drawing.Font("B Yekan", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lnumber.Location = new System.Drawing.Point(188, 1);
            this.Lnumber.Name = "Lnumber";
            this.Lnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lnumber.Size = new System.Drawing.Size(142, 45);
            this.Lnumber.TabIndex = 9;
            this.Lnumber.Text = "label1";
            this.Lnumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lnumber.Click += new System.EventHandler(this.Lnumber_Click);
            // 
            // Lcode
            // 
            this.Lcode.Font = new System.Drawing.Font("B Yekan", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lcode.Location = new System.Drawing.Point(354, 2);
            this.Lcode.Name = "Lcode";
            this.Lcode.Size = new System.Drawing.Size(114, 45);
            this.Lcode.TabIndex = 7;
            this.Lcode.Text = "label7";
            this.Lcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lfamily
            // 
            this.Lfamily.Font = new System.Drawing.Font("B Yekan", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lfamily.Location = new System.Drawing.Point(499, 2);
            this.Lfamily.Name = "Lfamily";
            this.Lfamily.Size = new System.Drawing.Size(144, 43);
            this.Lfamily.TabIndex = 3;
            this.Lfamily.Text = "label4";
            this.Lfamily.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lfamily.Click += new System.EventHandler(this.Lfamily_Click);
            // 
            // Lname
            // 
            this.Lname.Font = new System.Drawing.Font("B Yekan", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Lname.Location = new System.Drawing.Point(670, 10);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(68, 27);
            this.Lname.TabIndex = 1;
            this.Lname.Text = "Lname";
            this.Lname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lname.Click += new System.EventHandler(this.Lname_Click);
            // 
            // ListOfData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ListOfData";
            this.Size = new System.Drawing.Size(755, 45);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Lfamily;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lnumber;
        private System.Windows.Forms.Label Lcode;
    }
}
