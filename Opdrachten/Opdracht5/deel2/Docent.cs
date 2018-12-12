namespace deel2
{
    public class Docent : Persoon
    {
        public string Emailadres
        {
            get;
            set;
        }

        public Opleiding Opleidingen
        {
            get;
            set;
        }
        public int GenereerWachtwoord()
        {
            return 1234;
        }
    }
}