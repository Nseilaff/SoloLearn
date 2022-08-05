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
            string day = "Friday";
            int d = 10;
            bool t = true;
            double myDouble = 2.2;
            decimal myDecimal = 3.14159265m;
            decimal myDecimal_1 = 4.666m;
            char[] chars = new char[4];

            chars[0] = 'M';
            chars[1] = 'e';
            chars[2] = '&';
            chars[3] = 'I';
            Console.WriteLine($"Today is {day} and it is {d}am, and this is rendom {t} {myDouble} {myDecimal}");
            foreach (char c in chars)
            {
                Console.Write(c + " ");
            }
            
           
            Console.WriteLine("Thank you for participating!");

        }
    }
}
