using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char i = 'a'; i<='z'; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
