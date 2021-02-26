namespace ProjektReise
{
    public class IdentifikationsnummerGen
    {
        private string fluggastName, ticketNummer, indNummer, abflug, ankunft;
        
        public IdentifikationsnummerGen(string fluggastName, string abflug, string ankunft, string ticketNummer )
        {

           IndNummer += fluggastName.Substring(0, 1).ToUpper();
           IndNummer += abflug.Substring(0, 3).ToUpper();
           IndNummer += ankunft.Substring(0, 3).ToUpper();
           IndNummer += ticketNummer;

        }

        public string Ankunft
        {
            get => ankunft;
            set => ankunft = value;
        }

        public string Abflug
        {
            get => abflug;
            set => abflug = value;
        }

        public string FluggastName
        {
            get => fluggastName;
            set => fluggastName = value;
        }

        public string IndNummer
        {
            get => indNummer;
            set => indNummer = value;
        }
        
    }
}