using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbrariyUni.Src
{
    class Authors : DataAccess
    {
        private string Name;

        private string Family;
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
       
        public int insert()
        {

           // MessageBox.Show(""+name);
            string CommandText = "insert into authors(name,family) values ('" + name + "','" + family + "')";
                             
            int i=command(CommandText);
           // int f = selecting();
           // insertToBook_Writtenby(f, isbn);
            return i;


        }

        public void insertToBook_Writtenby(int authorId, string isbn)
        {


            string CommandText = "insert into Book_Writtenby(author_id,isbn) values ('" + authorId + "','" + isbn + "')";

            command(CommandText);
            con.Close();

        }
        public List<double> selectedAuthorId(string isbn)
        {
            string CommandText = "select author_id from Book_Writtenby where isbn='" + isbn + "'";
            Operations(CommandText);
            int i = 0;
            List<double> authorsId = new List<double>();
            while (dataReader.Read())
            {
                authorsId.Add(Convert.ToDouble(dataReader.GetValue(0)));

            }

            dataReader.Close();

            return authorsId;
        }
        public string selectedAuthorName(double  AuthorsID)
        {
            string CommandText = "select * from authors where author_id='" + AuthorsID + "'";
            Operations(CommandText);
            int i = 0;
            string AuthorName ="";
            while (dataReader.Read())
            {
                AuthorName = (dataReader.GetString(1) + " " + dataReader.GetString(2));

            }

            dataReader.Close();

            return AuthorName;
        }
        public DataTable selectAll()
        {
            string CommandText = "select * from authors ";
            return selectAllOfData(CommandText);


           // return AuthorName;
        }
    }
}
