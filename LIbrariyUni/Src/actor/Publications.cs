using LIbrariyUni.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbrariyUni.Src
{
    class Publications:DataAccess
    {
        private string Name;
        private int PublicationId;

        public string name
        {
            set { Name = value; }
            get { return Name; }
        }
        public int publicationId
        {
            set { PublicationId = value; }
            get { return PublicationId; }
        }
        public int insert()
        {


            string CommandText = "insert into Publications(name) values ('" + name + "')";
            
           int i= command(CommandText);

            return i;
        }

        public void insertToBooks_published(int publicId, string isbn)
        {


            string CommandText = "insert into Books_published(public_id,isbn) values ('" + publicId + "','"+isbn+"')";

             command(CommandText);
             con.Close();

        }
        public double selectedpublicationsId(string isbn)
        {
            string CommandText = "select public_id from Books_published where isbn='" + isbn + "'";
            Operations(CommandText);
            int i = 0;
            double publicationId = 0;
            while (dataReader.Read())
            {
                publicationId = (Convert.ToDouble(dataReader.GetValue(0)));

            }

            dataReader.Close();

            return publicationId;
        }
        public string selectedpublicationName(double publicationId)
        {
            string CommandText = "select * from Publications where public_id='" + publicationId + "'";
            Operations(CommandText);
            int i = 0;
            string publicationName = "";
            while (dataReader.Read())
            {
                publicationName = (dataReader.GetString(1) );

            }

            dataReader.Close();

            return publicationName;
        }
        public DataTable selectAll()
        {
            string CommandText = "select * from Publications ";
            return selectAllOfData(CommandText);


            // return AuthorName;
        }

    }
}
