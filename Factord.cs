using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Factor
    {
        public int N;
        public int i = 1;
        public void Factors()
        {
            Console.WriteLine("Enter the number");
            N = Convert.ToInt32(Console.ReadLine());

            while (i <= N / 2)
            {
                if(N%i == 0)
                {
                    Console.WriteLine(i);
                }
            }



        }



    }
}
