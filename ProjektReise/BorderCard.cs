using System;
using System.Windows.Forms;

namespace ProjektReise
{
    public partial class BorderCard : Form
    {
        private string namePass, sitzplatz, flugnummer, gate, borderZeit;
        Datenbank.Datenbank datenbank = new Datenbank.Datenbank();
        
        public BorderCard()
        {
            InitializeComponent();
            
            
        }
        private void BorderCard_Load(object sender, EventArgs e)
        {
            
            textBoxBorderCardName.Text = NamePass;
            textBoxBorderCardFlugnummer.Text = Flugnummer;
            textBoxBorderCardSitzplatz.Text = Sitzplatz;
            textBoxBorderCardGate.Text = GeneriereGate();
            textBoxBorderCardBorderZeit.Text = GeneriereBorderZeit();
            Console.WriteLine("Test!!" + NamePass);
        }
        
        private void buttonBorderCardSpeichern_Click(object sender, EventArgs e)
        {
            datenbank.BorderCardErstellen(NamePass, Sitzplatz, Flugnummer, textBoxBorderCardGate.Text, textBoxBorderCardBorderZeit.Text);
        }

        public string Flugnummer
        {
            get => flugnummer;
            set => flugnummer = value;
        }

        public string Sitzplatz
        {
            get => sitzplatz;
            set => sitzplatz = value;
        }

        public string NamePass
        {
            get => namePass;
            set => namePass = value;
        }

        public string GeneriereBorderZeit()
        {
            
            Random random = new Random();

            int tag = random.Next(1, 29);
            int monat = random.Next(1, 12);
            int stunden = random.Next(1, 24);
            int minuten = random.Next(1, 60);
            

            var temp = new DateTime(2021, monat, tag,stunden,minuten,00);
            return temp.ToString(System.Globalization.CultureInfo.CreateSpecificCulture("de-DE"));
        }
        public string GeneriereGate()
        {
            Random random = new Random();
            int num = random.Next(1, 12);
            char ch = Convert.ToChar(random.Next(65, 90));
            
            return "" + ch + num;
        }
        
    }
}