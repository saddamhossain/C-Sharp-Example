using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = false;
            if(condition == true)
            {
                Console.WriteLine("condition is true");
            }
            else if(condition == false)
            {
                Console.WriteLine("condition is false");
            }
            else
            {
                Console.WriteLine("unknown value");
            }
            Console.ReadKey();
        }
    }
}
