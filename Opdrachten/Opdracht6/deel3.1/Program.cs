using System;

namespace deel3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            VormFactory vormFactory = new VormFactory();
            IVorm vormA = vormFactory.GetVorm("Ruit");
            vormA.Teken();
        }
    }
}
