using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern1Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            int numOfRows = 5;

            for(row=1; row<=numOfRows; row++)
            {
                for(col=1; col<= row; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();       
            }
            Console.ReadKey();

        }
    }
}
