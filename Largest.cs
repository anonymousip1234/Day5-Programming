using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{

    internal class Largest
    {

        public int a;
        public int b;
        public int c;
        public void ThreeNumber()
        {
            Console.WriteLine("Enter the Three numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The largest number is" + a);


                }
                else
                {
                    Console.WriteLine("The largest number is " + c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("The largest number is" + b);

                }
                else
                {
                    Console.WriteLine("The largest number is" + c);
                }
            }

        }
    }

}


    