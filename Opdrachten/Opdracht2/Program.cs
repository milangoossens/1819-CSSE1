using System;

namespace Opdracht2
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
        static void Main(string[] args)
        {
            // Oefening 2
            

            string n = "";
            int a = 0;
            Console.WriteLine("Van welk getal wil je de faculteit berekenen?");
            n = Console.ReadLine();
            a = Convert.ToInt16(n);
            Console.WriteLine(faculteit(a));

            // Oefening 3
            
        }
    }
}
