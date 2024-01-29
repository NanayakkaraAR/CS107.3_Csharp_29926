using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_01
{
    internal class secque
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter a number");
                int number= Convert.ToInt32(Console.ReadLine());

                if(number%2 ==0)
                {
                    Console.WriteLine("Entered number is a even number");
                    Console.ReadLine();
                
                }
                else
                {
                    Console.WriteLine("Entered number is an odd number");
                    Console.ReadLine();

                }
            }
     

    }
}
