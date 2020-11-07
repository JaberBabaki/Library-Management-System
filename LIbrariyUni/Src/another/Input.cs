using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbrariyUni.Src
{
   public class Input
    {
        //--------Users------------//
            public double id;
            public double NumberStudent;
            public string Name;
            public string Family;
            public string Mobile;
            public string CodeMeli;
            public string Certificate;
            public string Born;
            public string FieldStudy;
            public string Email;
            public string Adress;
            public string Picture;
            public string Date;
        //--------Books------------//
       // public double id;
             public string Isbn;
             public int YearPublication;
             public string Title;
             //private string picture;
             public int NumberBook;
             public int Repeat;
        //--------Authors------------//
            //public string name;
             public int PublicationId;

        //--------Authors------------//
        //public string name;
        public int AuthorId;


        //--------Users(set,get)------------//
       /* public void setUser(Boolean seORge, double numberStudent, string name, string family, string mobile, string codeMeli, string certificate, string born, string fieldStudy, string email, string adress, string picture)
        {
            if (seORge)
            {
                NumberStudent = numberStudent;
                Name = name;
                Family = family;
                Mobile = mobile;
                CodeMeli = codeMeli;
                Certificate = certificate;
                Born = born;
                FieldStudy = fieldStudy;
                Email = email;
                Adress = adress;
                Picture = picture;
            }
            else
            {
               
            }
        }
        

       
      /*  public double numberStudent
        {
            set {numberStudent=value ;}
            get { return NumberStudent; }
        }*/

      
    }
}
