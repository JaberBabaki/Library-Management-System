using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbrariyUni.Src
{
    class Users:DataAccess
    {
        private double NumberStudent;
        private string Name;
        private string Family;
        private string Mobile;
        private string CodeMeli;
        private string Certificate;
        private string Born;
        private string FieldStudy;
        private string Email;
        private string Adress;
        private string Picture;
        private string Date;
        private int Id;
        public int id
        {
            set { Id = value; }
            get { return Id; }
        }
        public double numberStudent
        {
            set { NumberStudent = value; }
            get { return NumberStudent; }
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
        public string mobile
        {
            set { Mobile = value; }
            get { return Mobile; }
        }
        public string codeMeli
        {
            set { CodeMeli = value; }
            get { return CodeMeli; }
        }
        public string certificate
        {
            set { Certificate = value; }
            get { return Certificate; }
        }
        public string born
        {
            set { Born = value; }
            get { return Born; }
        }
        public string fieldStudy
        {
            set { FieldStudy = value; }
            get { return FieldStudy; }
        }
        public string email
        {
            set { Email = value; }
            get { return Email; }
        }
        public string adress
        {
            set { Adress = value; }
            get { return Adress; }
        }
        public string picture
        {
            set { Picture = value; }
            get { return Picture; }
        }
        public string date
        {
            set { Date = value; }
            get { return Date; }
        }
        public Users() : base() { }
        public int  insert()
        {

            
            string CommandText = "insert into Users(number_student,name,family,mobile,code_meli,certificate,born,field_staudy,email," +
                              "Address,picture,date) values ('" + numberStudent + "','" + name + "','" + family + "','" +
                              mobile+"','"+codeMeli+"','"+certificate+"','"+born+"','"+fieldStudy+"','"+email+"','"+adress+"','"+picture+"','"+date+"')";
            return  command(CommandText);  
            

        }
       public List<Input> selected(){
           string CommandText = "select * from Users";
            Operations(CommandText);
            int i=0;
            while (dataReader.Read())
            {
                Input inn = new Input();
                inn.id = Convert.ToDouble(dataReader.GetValue(0));
                inn.NumberStudent = dataReader.GetInt64(1);
                inn.Name = dataReader.GetString(2);
                inn.Family = dataReader.GetString(3);
                inn.Mobile = dataReader.GetString(4);
                inn.CodeMeli = dataReader.GetString(5);
                inn.Certificate = dataReader.GetString(6);
                inn.Born = dataReader.GetString(7);
                inn.FieldStudy = dataReader.GetString(8);
                inn.Email = dataReader.GetString(9);
                inn.Adress = dataReader.GetString(10);
                inn.Picture = dataReader.GetString(11);
                inn.Date = dataReader.GetString(12);

                i++;
                input.Add(inn);
            }
            dataReader.Close();
            return input;
       }
       public int deleted()
       {
           string CommandText = "delete from Users where number_student='" + numberStudent + "'";
           return command(CommandText);
       }
       public int updated()
       {
           string CommandText = "update  Users set number_student='" + numberStudent + "',name='" + name + "',family='" + family + "',mobile='" + mobile + "',code_meli='" + codeMeli + "',certificate='" + certificate + "',born='" + born + "',field_staudy='" + fieldStudy + "',email='" + email + "',Address='" + adress + "',picture='" + picture + "'where id ='" + id + "'";
           return command(CommandText);
       }
       public List<Input> selectByNumberStudent()
       {
           string CommandText = "select * from Users where number_student='" + numberStudent + "'";// "select id,name,family,pic from Users where number_student='" + 93181116 + "'";
           Operations(CommandText);
           int i = 0;
           while (dataReader.Read())
           {
               Input inn = new Input();
               inn.id = Convert.ToDouble(dataReader.GetValue(0));
               inn.Name = dataReader.GetString(2);
               inn.Family = dataReader.GetString(3);
               inn.Picture = dataReader.GetString(11);

               i++;
               input.Add(inn);
           }
           dataReader.Close();
           return input;
       }
       public List<Input> login()
       {
          // MessageBox.Show("" + numberStudent);
          // "Select name,password From registration where name=@name and password=@password"
           string CommandText = "select * from Users where number_student='" + numberStudent + "'";// "select id,name,family,pic from Users where number_student='" + 93181116 + "'";
           Operations(CommandText);
           int i = 0;
           while (dataReader.Read())
           {
               Input inn = new Input();
               inn.NumberStudent = Convert.ToDouble(dataReader.GetValue(1));
               inn.Name = dataReader.GetString(2);
               inn.Family = dataReader.GetString(3);
               inn.Email = dataReader.GetString(9);

               i++;
               input.Add(inn);
           }
           dataReader.Close();
           return input;
       } 
    }
}
