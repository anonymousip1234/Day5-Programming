using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class EvenOdd
    {
        public int n;
        public void OddOrEven()
        {
            Console.WriteLine("Enter The Number");
            n = Convert.ToInt32(Console.ReadLine());
            
            if (n%2 == 0)
            {
                Console.WriteLine("The number is even");

            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }
    }
}
