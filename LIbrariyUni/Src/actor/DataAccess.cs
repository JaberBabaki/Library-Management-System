using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbrariyUni.Src
{
    class DataAccess
    {

        protected SqlConnection con = new SqlConnection();
        protected SqlCommand com = new SqlCommand();
        protected SqlDataReader dataReader;
        protected List<Input> input = new List<Input>();
        /////
        protected SqlDataAdapter da = new SqlDataAdapter();
        protected DataTable dt = new DataTable();
        public  DataAccess()
        {
            con.ConnectionString = "Data Source=.;Initial Catalog=LibraryUni;Integrated Security=True";
            con.Open();
        }

        protected int command(string  strsql)
        {
            try
            {
                com.CommandText = strsql;
                com.Connection = con;
                com.CommandType = CommandType.Text;

                com.ExecuteNonQuery();
                }
            catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                    return 0;
                }
               // con.Close();
             return 1;
             
        }
        protected void Operations(string strsql)
        {
            try{

            
            com = new SqlCommand();
            com.CommandText = strsql;
            com.Connection = con;
            com.CommandType = CommandType.Text;
            dataReader = com.ExecuteReader();
            }
           catch (Exception e)
                {
                   
                 }
           // con.Close();
           /* int i=0
            while (dataReader.Read())
            {

                input[i]. = dataReader.GetInt32(0);
                i++
            }*/

        }

        public DataTable selectAllOfData(string strsql)
        {
            com = new SqlCommand();
            com.Connection = con;
            com.CommandText = strsql;
            com.CommandType = CommandType.Text;
            dt = new DataTable();
            da = new SqlDataAdapter(com);
            da.Fill(dt);
            return dt;
        }
    }
}
