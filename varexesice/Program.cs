using System;

namespace varexesice
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables deceralations
            string dogName;

            int dogAge;

            double cost;

            decimal thisMuch;

            char nickName;

            bool isBestBoy;

            // variables initializtion

            dogName = "Charlie";

            dogAge = 4;

            isBestBoy = true;

            cost = 400.00;

            thisMuch = 70;

            nickName = 'C';



            Console.WriteLine($"{dogName} is {dogAge} and is the best boy {isBestBoy}");
            Console.WriteLine($"Sometimes I call him {nickName}. I paid {cost} for him but would of paid anything");
            Console.WriteLine($"Hes a big ol' boy weighing in at {thisMuch}");
        }
    }
}

