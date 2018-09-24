using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Program
    {
        static void Process(string s)
        {
            string get = "";
            string time = "";
            string hh = "";
            string mm = "";
            string date = "";
            string dd = "";
            string MM = "";
            string YYYY = "";
            int flag = 0;
            for(int i = 0; i < s.Length; i++)
            {
                if (flag == 0)
                {
                    
                    if (s[i].Equals(','))
                    {
                        flag = 1;
                        time = get;
                        get = "";
                    }
                    else
                        get += s[i];
                }
                else
                {
                    if(!s[i].Equals(" "))
                    {
                        get += s[i];

                    }
                }
            }
            date = get;
            string[] spl;
            spl = time.Split(':');
            hh = spl[0];
            mm = spl[1];
            spl = date.Split('/');
            dd = spl[0];
            MM = spl[1];
            YYYY = spl[2];
            Console.WriteLine("hh: " + hh);
            Console.WriteLine("mm: " + mm);
            Console.WriteLine("dd: " + dd);
            Console.WriteLine("MM: " + MM);
            Console.WriteLine("YYYY: " + YYYY);

        }
        static void Main(string[] args)
        {
            string cnt = args[0]+args[1];
            Process(cnt);

        }
    }
}
