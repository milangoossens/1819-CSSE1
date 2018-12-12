namespace deel2
{
    public abstract class Abstractinfo
    {
        private string info;
        public string InfoDetail
        {
            get;
            set;
        }
        public abstract void GeefInformatie();
        //abstract string GeefInformatie();
    }
}