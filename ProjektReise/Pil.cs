using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProjektReise
{
    public partial class Pil : Form
    {
        private List<PilAusgabe> list;

        private Datenbank.Datenbank datenbank = new Datenbank.Datenbank();

        private bool auslesenCheck = false;
        
        public Pil()
        {
            InitializeComponent();
        }
        private void Pil_Load(object sender, EventArgs e)
        {
            
        }
        
        private void buttonAuslesen_Click(object sender, EventArgs e)
        {
            list = datenbank.AuslesenPil(textBoxAuslesen.Text);
            string[] zeile = new string[9];
            
            Console.WriteLine("Geladen");
            
            foreach (var element in list)
            {

                datenbank.FluggastInformationen(element.FluggastId);
                datenbank.flugzeugInformationen(element.FlugzeugId);
                Console.WriteLine("-----------------------------");
                Console.WriteLine(element.TicketId);
                Console.WriteLine(element.FluggastId);
                Console.WriteLine(element.FlugGastTicket);
                Console.WriteLine(element.FluGastTicketTyp);
                Console.WriteLine(element.GebaeckId);
                Console.WriteLine(element.AbflugHafen);
                Console.WriteLine(element.ZielflugHafen);
                Console.WriteLine(element.GebaeckIdent);
                Console.WriteLine(element.Flugnummer);
                Console.WriteLine(element.FlugzeugId);
                Console.WriteLine(element.Sitzplatze);
                Console.WriteLine("-----------------------------");

                zeile[0] = element.TicketId;
                zeile[1] = datenbank.FluggastName;
                zeile[2] = element.FluGastTicketTyp;
                zeile[3] = element.AbflugHafen;
                zeile[4] = element.ZielflugHafen;
                zeile[5] = element.GebaeckIdent;
                zeile[6] = element.Flugnummer;
                zeile[7] = element.Sitzplatze;
                zeile[8] = datenbank.FlugzeugName;

                ListViewItem listViewItem = new ListViewItem(zeile);
                pilList.Items.Add(listViewItem);
                
            }

        }


        private void pilList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonLoeschen_Click(object sender, EventArgs e)
        {
            pilList.Items.Clear();
        }
    }
}