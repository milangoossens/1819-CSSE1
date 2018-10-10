using System;

namespace lesweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rekenmachine
            int deling(int c, int d)
            {
                return c / d;
            }

            int optellen(int c, int d)
            {
                return c + d;
            }

            int vermenigvuldigen(int c, int d)
            {
                return c * d;
            }

            int aftrekken(int c, int d)
            {
                return c - d;
            }

            int a = 5;
            int b = 10; 

            int resultaat1 = optellen(a,b);
            int resultaat2 = aftrekken(a,b);
            int resultaat3 = deling(a,b);
            int resultaat4 = vermenigvuldigen(a,b);

            Console.WriteLine(resultaat1);
            Console.WriteLine(resultaat2);
            Console.WriteLine(resultaat3);
            Console.WriteLine(resultaat4);
        }
    }
}
