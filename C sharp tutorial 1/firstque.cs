using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutorial_01
{
    internal class firstque
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length");
            int l= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the width");
            int w= Convert.ToInt32(Console.ReadLine());

            CalArea(l,w);

        }

        static void CalArea(int length, int width)
        {
            int area; 
                area=length * width ;
            Console.WriteLine("The area is "  + area);
            Console.ReadLine();
        }
           

            

    }
}
