using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LIbrariyUni.Src
{
    class G : ApplicationContext
    {
        public static  string DEFAULT_PIC_BOOK = @"C:\Users\User\Desktop\library\bok.jpg";
        public static string  DEFAULT_PIC_USER = @"C:\Users\User\Desktop\library\pers.png";
        public static int IDENTITY = 0;
        Main frm1 = new Main();
        public G()
        {
            frm1.Show();
        }
    }
}
