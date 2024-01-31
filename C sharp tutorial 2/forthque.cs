using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace lab01_que4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value");
            int num= Convert.ToInt32(Console.ReadLine());

            int result;
            result = fib(num);
            Console.WriteLine("fibbonacci value of " + num + "is" + result);
            Console.ReadLine();
        }

        public static int fib(int num)
        {
            if(num == 0)
            {

                return 0;

            }
            if (num == 1 || num==2 )
            {
                return 1;
            }
            else
            {
                return fib(num-1)+fib(num-2);

            }
        }
    }

}


