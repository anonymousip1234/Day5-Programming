using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    internal class HeadTail
    {
        public int loops = 1;
        



        public int generateDIgits()
        {
            return new Random().Next(0, 2);

        
        }
      
        
        
        
        public void HeadTailPer()
        {
            int x;
            int Head = 0;
            int Tail = 0;
            const int H = 1;
            const int T = 0;


            Console.WriteLine("ENter the number of times you want to flip");
            x = Convert.ToInt32(Console.ReadLine());
            

            while(loops <= x)
            {

                switch (generateDIgits())
                {
                    case H:
                        Head++;
                            ; break;

                    case T:
                        Tail ++; break;


                }

                loops++;


            }
            float HeadP = (Head / (Head + Tail)) * 100;
            float TailP = (Tail / (Head + Tail)) * 100;


            Console.WriteLine("The Head Percentage is " + HeadP);
            Console.WriteLine("The Tail Percentage is " + TailP);





        }

    }
}
