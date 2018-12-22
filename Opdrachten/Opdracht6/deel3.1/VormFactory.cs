namespace deel3._1
{
    public class VormFactory
    {
        public IVorm GetVorm(string typeVorm)
        {
            if(typeVorm == null)
            {
                return null;
            }
            else if(typeVorm.Equals("Cirkel"))
            {
                return new Cirkel();
            }
            else if(typeVorm.Equals("Vierkant"))
            {
                return new Vierkant();
            }
            else if(typeVorm.Equals("Rechthoek"))
            {
                return new Rechthoek();
            }
            else if(typeVorm.Equals("Ruit"))
            {
                return new Ruit();
            }
            else if(typeVorm.Equals("Trapezium"))
            {
                return new Trapezium();
            }
            else if(typeVorm.Equals("Parallellogram"))
            {
                return new Parallellogram();
            }

            return null;
        }
    }
}