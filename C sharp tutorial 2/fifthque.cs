using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab01que5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number : ");
            number=int.Parse(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                int result = number * i;
                Console.WriteLine(number + "x" + i + "=" + result);
            }
            Console.ReadLine();
        }
    }
}
