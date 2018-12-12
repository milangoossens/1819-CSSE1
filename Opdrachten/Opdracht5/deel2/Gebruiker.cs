namespace deel2
{
    public class Gebruiker
    {
        protected string wachtwoord;

        public string Gebruikersnaam
        {
            get;
            set;
        }
        public virtual string GenereerWachtwoord()
        {
            return "Gebruiker - wachtwoord";
        }
        public string GenereerGebruikersnaam()
        {
            return "gebruikersnaam";
        }
        public Gebruiker()
        {
            this.wachtwoord = GenereerWachtwoord();
        }
    }
}