using System;

namespace deel2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            Persoon p1 = new Persoon();
            string ww = p1.GenereerWachtwoord();
            Console.WriteLine(ww);

            Student s1 = new Student();
            Console.WriteLine(s1.GenereerWachtwoord());
        }
    }
}
