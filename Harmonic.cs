using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Harmonic


    {

        public float number = 0;
        public int i = 1;
        public void Harmonicnum()
        {
            int x;
            
            Console.WriteLine("Enter The number");
            x = Convert.ToInt32(Console.ReadLine());
            
            while(i<=x)
            {
                float number =  + (1 / i);
                
                i++;
            }


            Console.WriteLine("The summation is " + number);
        }
         
    }
}
