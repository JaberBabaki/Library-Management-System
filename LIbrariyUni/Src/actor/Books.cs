using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbrariyUni.Src
{
    class Books:DataAccess
    {
        private double Id;
        private string Isbn;
        private int YearPublication;
        private string Title;
        private string Picture;
        private int NumberBook;
        private int Repeat;
        private string Date;
        public double id
        {
            set { Id = value; }
            get { return Id; }
        }
        public string isbn
        {
            set { Isbn = value; }
            get { return Isbn; }
        }
        public int yearPublication
        {
            set { YearPublication = value; }
            get { return YearPublication; }
        }
        public string title
        {
            set { Title = value; }
            get { return Title; }
        }
        public string picture
        {
            set { Picture = value; }
            get { return Picture; }
        }
        public int numberBook
        {
            set { NumberBook = value; }
            get { return NumberBook; }
        }
        public int repeat
        {
            set { Repeat = value; }
            get { return Repeat; }
        }
        public string date
        {
            set { Date = value; }
            get { return Date; }
        }
        public int insert()
        {


            string CommandText = "insert into Books(isbn,year_Publication,title,picture,number_book,repeat,date ) values ('" + isbn + "','" + yearPublication + "','" + title + "','" +
                             
                              picture + "','" + numberBook + "','" + repeat +"','"+date+"')";
            int i= command(CommandText);
            con.Close();
            return i;

         
        }
        public List<Input> selected()
        {
            string CommandText = "select * from Books ";
            Operations(CommandText);
            int i = 0;
          
            while (dataReader.Read())
            {
                Input inn = new Input();
                inn.id = Convert.ToDouble(dataReader.GetValue(0));
                inn.Isbn = dataReader.GetString(1);
                inn.YearPublication = Convert.ToInt16(dataReader.GetValue(2));
                inn.Title = dataReader.GetString(3);
                inn.Picture = dataReader.GetString(4);
                inn.NumberBook = Convert.ToInt16(dataReader.GetValue(5));
                inn.Repeat = Convert.ToInt16(dataReader.GetValue(6));
                inn.Date = dataReader.GetString(7);

                i++;
                input.Add(inn);
            }

            dataReader.Close();
            
            return input;
        }
        public List<Input> selectedAuthorId()
        {
            string CommandText = "select * from Books";
            Operations(CommandText);
            int i = 0;
            string isbnS = "";
            while (dataReader.Read())
            {
                Input inn = new Input();
                inn.id = Convert.ToDouble(dataReader.GetValue(0));
                inn.Isbn = dataReader.GetString(1);
                inn.YearPublication = dataReader.GetInt16(2);
                inn.Title = dataReader.GetString(3);
                inn.Picture = dataReader.GetString(4);
                inn.NumberBook = dataReader.GetInt16(5);
                inn.Repeat = dataReader.GetInt16(6);
                inn.Date = dataReader.GetString(7);
                //  isbnS = inn.Isbn;
                i++;
                input.Add(inn);
            }

            dataReader.Close();

            return input;
        }
        public int deleted()
        {
            string CommandText = "delete from Books where isbn='" + isbn + "'";
            return command(CommandText);
        }
        public List<Input> selectByIsbn()
        {
            MessageBox.Show(""+isbn.Length);
            string CommandText = "select * from Books where isbn='" + isbn + "'";// "select id,name,family,pic from Users where number_student='" + 93181116 + "'";
            Operations(CommandText);
            int i = 0;
            while (dataReader.Read())
            {
                Input inn = new Input();
                inn.id = Convert.ToDouble(dataReader.GetValue(0));
                inn.YearPublication =Convert.ToInt16( dataReader.GetValue(2));
                inn.Title = dataReader.GetString(3);
                inn.Picture = dataReader.GetString(4);
                inn.Repeat = Convert.ToInt16(dataReader.GetValue(6));
               

                i++;
                input.Add(inn);
            }
            dataReader.Close();
            return input;
        }
        public int updaded()
        {
            MessageBox.Show("" + repeat + isbn.Length);
            string CommandText = "update  Books set repeat='" + repeat + "'where isbn='"+isbn+"'";
            return command(CommandText);
        }
    }
}
