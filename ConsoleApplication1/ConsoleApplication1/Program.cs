using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
   public class Program
    {
        string user;
        int age;

        public Program()
        {
            user = "saddam hossain";
            age = 25;
            Console.WriteLine("I am {0} and i am {1} years old",user,age);
        }

        public Program(int i, string nammes)
        {

        }
     
        static void Main(string[] args)
        {
            Program ob = new Program();
            Console.ReadKey();
        }
    }
}
