using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = "Monday";
            int d = 10;
            bool t = true;
            double myDouble = 2.2;
            decimal myDecimal = 3.14159265m;
            char[] chars = new char[4];

            chars[0] = 'X';
            chars[1] = '\x0058';
            chars[2] = (char)88;
            chars[3] = '\u0058';

            foreach (char c in chars)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine(d);
            Console.WriteLine(day);
            Console.WriteLine(t);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDecimal);

        }
    }
}
