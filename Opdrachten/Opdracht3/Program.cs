using System;

namespace Opdracht3
{
    class Program
    {
        public static int faculteit(int getal){
                int resultaat = 1;
                for(int i=1;i<=getal;i++){
                    resultaat*= i;
                }
                return resultaat;
            }
        
        public static void alletafels(){
                int resultaat= 0;
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine("De tafel van " + i + ": ");
                    for (int j = 0; j < 11; j++)
                    {
                        resultaat = i * j;
                        Console.WriteLine(resultaat);
                    }
                }
            }

            public static void gekozenTafel(int getal){
                int resultaat = 0;
                Console.WriteLine("De tafel van " + getal + ": ");
                for (int i = 1; i < 11; i++)
                {
                    resultaat = getal * i;
                    Console.WriteLine(resultaat);
                }
            }

        static void Main(string[] args)
        {
            // oefening 1 - Update
            

            alletafels();

            string inputString = "";
            int inputGetal = 0;
            Console.WriteLine("Van welk getal wil je de tafel berekenen?");
            inputString = Console.ReadLine();
            inputGetal = Convert.ToInt16(inputString);
            gekozenTafel(inputGetal);

            // Oefening 2 - Update 

            string inputString2 = "";
            int inputGetal2 = 0;
            Console.WriteLine("Van welk getal wil je de faculteit berekenen?");
            inputString2 = Console.ReadLine();
            inputGetal2 = Convert.ToInt16(inputString2);
            Console.WriteLine(faculteit(inputGetal2));

            
        }
    }
}
