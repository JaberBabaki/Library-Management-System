using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIbrariyUni.Src
{
    class Calender
    {


            public  int DAY_MS = 86400000;   
            public static int[]     months = new int[]{ 31, 31, 31, 31, 31, 31, 30, 30, 30, 30, 30, 29 };
            public string  MilliTimeStamp(DateTime d1)
            {
                try
                {
                   // DateTime d1 = new DateTime(2014, 01, 23);
                    DateTime d3 = new DateTime(1970, 01, 01).ToUniversalTime();
                    TimeSpan ts = new TimeSpan(d1.Ticks-d3.Ticks);
                   return getJalaliFromMs(Convert.ToInt64(ts.TotalMilliseconds));
                }
                catch
                {
                    return "";
                }
            }

            public  String getJalaliFromMs(long ms)
            {
                long days = ms / DAY_MS;

                int monthIndex = 10;
                days -= 18;

                int year = 1348;

                while (true)
                {
                    if (days > months[monthIndex])
                    {
                        days -= months[monthIndex];
                    }
                    else
                    {
                        break;
                    }
                    monthIndex++;
                    if (monthIndex == 12)
                    {
                        if (((year - 1347) % 4) == 0)
                        {
                            days -= 1;
                        }
                        year++;
                        monthIndex = 0;
                    }
                }

                return year + "/" + (monthIndex + 1) + "/" + (days-1);
            }

           
    }
}
