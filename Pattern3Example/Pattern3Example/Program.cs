using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern3Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int noOfRows, noOfCols, row, col1, col2;
            noOfRows = 5;
            noOfCols = noOfRows - 1;
            for(row=1; row<=noOfRows; row++)
            {
                for(col1=1; col1<=noOfCols; col1++)
                {
                    Console.Write(" ");
                }
                noOfCols--;
                for(col2=1; col2<=row;col2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
