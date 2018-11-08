using System;

namespace Opdracht3
{
    class Program
    {
        // Je kan sorteren wanneer je gebruik maakt van 2 strings maar dan moet je dit zelf initialiseren.
        
        public static void prijslijst(double[] prijzen,string[] dranksoort){
            for (int i = 0; i < 7; i++)
            {
                if(dranksoort[i].Length <= 5 ){
                    Console.WriteLine(dranksoort[i] + "\t" + "\t : " + prijzen[i]);
                }
                else{
                    Console.WriteLine(dranksoort[i] + "\t : " + prijzen[i]);
                }
                
            }
        }

        public static void opzoekenItem(double[] prijzen,string[] dranksoort){
            string inputString = "";
            Console.WriteLine("Wat wil je opzoeken in het menu?");
            inputString = Console.ReadLine();
            int teller = 0;
            
            for (int i = 0; i < 7; i++)
            {
                if(dranksoort[i] == inputString){
                    Console.WriteLine(inputString + " kost " + prijzen[i] + " euro");
                }
                else{
                    teller++;
                }
            }

            if(teller == 7){
                Console.WriteLine(inputString + " staat niet in het menu ");
            }
        }
        static void Main(string[] args)
        {
            double[] prijzen = { 1, 1.5, 2, 3, 2, 5, 4 };
            string[] dranksoort = { "plat water", "cola 25 cl", "cola 33 cl", "witte wijn", "pils", "toast", "kaasplank" };

            prijslijst(prijzen, dranksoort);
            opzoekenItem(prijzen,dranksoort);

        }
    }
}
