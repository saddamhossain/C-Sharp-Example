using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern2Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int row, col;
            int noOfRows = 5;
            int noOfCols = noOfRows;
            for(row=1; row<=noOfRows; row++)
            {
                for(col=1; col<=noOfCols; col++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                noOfCols--;
            }
            Console.ReadKey();
        }
    }
}
