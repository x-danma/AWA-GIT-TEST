using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GITTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";

            foreach (var item in hello)
            {
                Console.Write(item);
            }
            Console.WriteLine("Displaying days left in month");
            
            for (int i =0; i <= DateTime.DaysInMonth(DateTime.Now.Year,DateTime.Now.Month); i++)
            {
                if (i > DateTime.Now.Day)
                {
                    Console.WriteLine("Day {0} left in {1}", i,NameOfMonth(DateTime.Now.Month));
                }
            }
            Console.WriteLine("Adding 1 and 7");
            int a = 1;
            int b = 7;

            Console.WriteLine(Convert.ToString(AddTwoNumbers(a,b)));

        }

        public static string NameOfMonth(int number)
        {
            string[] month = { "January", "February", "March", "April",
                "May", "June", "July", "August", "Semptember", "October", "November", "December" };
            return month[number-1];
        }

       static public int AddTwoNumbers(int x, int z)
        {
            int c = x + z;
            return c;
        }
    }
}
