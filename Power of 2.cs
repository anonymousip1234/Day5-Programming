using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Power_of_2

    {

        public int i = 1;
        public int mainNum = 1;
        public void Power()
        {
            
              int x;
             
        
            Console.WriteLine("Enter The number");
            x = Convert.ToInt32(Console.ReadLine());

            while (i <= x)
            {
                mainNum = mainNum * 2;
                Console.WriteLine(mainNum);
                i++;
            }

          
           
           
        }
        
        
    }

}
