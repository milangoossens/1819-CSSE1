namespace deel2
{
    public class Persoon : Gebruiker, IInformatie
    {
        public string Naam 
        {  
            get;
            set;
        }
        public string VolledigeNaam 
        {
            get;
        }
        private string naam;
        private string voornaam;

        /* public Date Geboortedatum
        {
            get;
            set;
        }*/
        public string Voornaam
        {
            get
            {
                return this.voornaam;
            }
            set
            {
                this.voornaam = value;
            }
        }
        public int Leeftijd()
        {
            return 678;
        }
        public string GenereerWachtwoord(string input)
        {
            return "Persoon - wachtwoord";
        }
        public string GenereerWachtwoord(int input)
        {
            return "Persoon - wachtwoord";
        }
        public override string GenereerWachtwoord()
        {
            return "Persoon - wachtwoord";
        }

        /* public int GenereerWachtwoord()
        {
            return 368;
        }*/
       
       public string ToString()
       {
           return "waarden van object persoon";
       }
    }
}