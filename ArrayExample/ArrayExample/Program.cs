using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();
            myList.Add(12);
            myList.Add(111);
            myList.Add(222);
            int sum = 0;
         

            foreach(int abc in myList)
            {
                 sum = sum + abc;
                Console.WriteLine(sum);
            }



            Console.ReadKey();
        }
    }
}
