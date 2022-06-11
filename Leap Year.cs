using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class Leap_Year
    {
        public void Leap()
        {

            int year;
            Console.WriteLine("Enter The year");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 100 == 0)
            {
                Console.WriteLine(year + "Is not a Leap Year");

            }
            else
            {
                if (year % 4 == 0)
                {
                    Console.WriteLine(year + "Is a Leap Year");

                }
                else
                {
                    Console.WriteLine(year + "Is not a Leap Year");
                }
            
            
            }   

        }
        

    }
}
