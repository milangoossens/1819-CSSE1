using System;

namespace lesweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string tekst = "dit is een tesjte!";
            int lengte = tekst.Length;

            for (int i = 0; i < lengte; i++)
            {
                string tekst2 = tekst.ToUpper();
                char deel = tekst[i];
                char deel2 = tekst2[i];
                char deel3 = tekst2[i];
                if(deel3 == ' '){
                    deel3 = '_';
                }
                Console.WriteLine(deel + " " + deel2 + " " + deel3);
            }

            

        }
    }
}
