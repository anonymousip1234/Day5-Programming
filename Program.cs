namespace BasicProgram

{

   class Program
    {

        public static void Main(string[]args)
        {

            int n;
            Console.WriteLine("Welcome To Day 6 of programming,Choose from the following numbers");
            Console.WriteLine("1.Even odd");
            Console.WriteLine("2.Power of 2");
            Console.WriteLine("3.Leap year");
            Console.WriteLine("4.Factors");
            Console.WriteLine("5.Largest among 3");
            Console.WriteLine("6.Harmonic");
            Console.WriteLine("7.Head Tail");
            n = Convert.ToInt32(Console.ReadLine());


            switch (n)
            {
                case 1:
                    EvenOdd evenOdd = new EvenOdd();
                    evenOdd.OddOrEven();
                    break;

                case 2:
                    Power_of_2 power_Of_2 = new Power_of_2();
                    power_Of_2.Power();
                    break;


                case 3:
                    Leap_Year leap_Year = new Leap_Year();
                    leap_Year.Leap();
                    break;


                case 4:
                    Factor factor = new Factor();
                    factor.Factors();
                    break;

                case 5:
                    Largest largest = new Largest();
                    largest.ThreeNumber();
                    break;

                case 6:
                    Harmonic harmonic = new Harmonic();
                    harmonic.Harmonicnum();
                    break;

                case 7:
                    EvenOdd odd = new EvenOdd();
                    odd.OddOrEven();
                    break;



            }






        }

    }


}