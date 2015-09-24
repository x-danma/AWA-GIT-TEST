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
            Console.WriteLine("Hej Marcus!");
            Console.WriteLine("Tjenare tjenare!");
            string hello = "Hello";

            foreach (var item in hello)
            {
                Console.WriteLine(item);
            }
            int a = 1;
            

            int b = 7;

            Console.WriteLine(Convert.ToString(AddTwoNumbers(a,b)));

        }

       static public int AddTwoNumbers(int x, int z)
        {
            int c = x + z;
            return c;
        }
    }
}
