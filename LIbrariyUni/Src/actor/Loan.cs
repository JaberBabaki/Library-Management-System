using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbrariyUni.Src
{
    class Loan:DataAccess 
    {
        private string Isbn;
        private double NumberStudent;
        private  string DateDelivery;
        private string DateReturn;
        private int Flag;
        private int Year;
        private string Title;
        private string Name;
        private string Family;
        
        public string isbn{
            set { Isbn = value; }
            get { return Isbn; }
        }
        public double numberStudent
        {
            set { NumberStudent = value; }
            get { return NumberStudent; }
        }
        public string dateDelivery
        {
            set { DateDelivery = value; }
            get { return DateDelivery; }
        }
        public string dateReturn
        {
            set { DateReturn = value; }
            get { return DateReturn; }
        }
        public int flag
        {
            set { Flag = value; }
            get { return Flag; }
        }
        public int year
        {
            set { Year = value; }
            get { return Year; }
        }
        public string title
        {
            set { Title = value; }
            get { return Title; }
        }
        public string name
        {
            set { Name = value; }
            get { return Name; }
        }
        public string family
        {
            set { Family = value; }
            get { return Family; }
        }

        public int insertLoan()
        {
            MessageBox.Show("j" + title+"  " +year);
            string CommandText = "insert into loan(isbn,number_student,date_Delivery,date_return,flag,year,title,name,family) values ('" +
                   isbn + "','" + numberStudent + "','" + dateDelivery + "','" + dateReturn + "','" + flag + "','" + year + "','" +
                   title + "','" + name + "','" + family+ "')";
            return command(CommandText);  
        }
    }
}
