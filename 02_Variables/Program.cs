using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.OutputEncoding = Encoding.UTF8;


            double x = 10.2;
            double y = x + 2;
           
            Console.WriteLine(x + y + " \u20BA");
            Console.ReadKey();
        }
    }
}
