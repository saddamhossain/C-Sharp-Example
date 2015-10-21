using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = new int[4];
            number[0] = 12;
            number[1] = 20;
            number[2] = 32;
            number[3] = 1;                                                                             
            foreach(int num in number)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
            
        }
    }
}
