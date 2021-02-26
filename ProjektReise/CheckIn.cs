using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProjektReise
{
    public partial class CheckIn : Form
    {
        private double gebaeckPreis;
        private bool preisCheck = false;
        private bool wiegenCheck = false;
        private bool sitzplatzCheck = false;
        private double preis;
        private int anzalFreiePlaetze;
        
        Datenbank.Datenbank datenbank = new Datenbank.Datenbank();
        public CheckIn()
        {
            InitializeComponent();
            buttonBorderCard.Hide();
            richTextBox.Hide();
            
        }

        private void buttonAuslesen_Click(object sender, EventArgs e)
        {
            

            if (!wiegenCheck)
            {
                textBoxWiegen.Text = "Zeuerst wiegen!";
                labelInfo.Text = "Zuerst wiegen!";
                textBoxIdentifkationsnummer.Text = "Gepäck muss zuerst gewogen werden!";
            }
            
            if (datenbank.TicketIdauslesen(textBoxTicketNummer.Text))
            {
                textBoxFluggastId.Text = datenbank.FluggastId;
                textBoxTicket.Text = datenbank.FluggastTicket;
                textBoxName.Text = datenbank.FluggastName;
                textBoxTicketArt.Text = datenbank.FluggastTicketArt;
                textBoxAnHafen.Text = datenbank.Ankunftflughafen;
                textBoxAbFlug.Text = datenbank.Abflughafen;
                textBoxFlugnummer.Text = datenbank.FlugNummer;
                
                datenbank.flugzeugInformationen(datenbank.FlugzeugId);
                int temp;
                
                Int32.TryParse(datenbank.FlugzeugSitzplatz, out temp);
                int[] arr = new int[temp];
                for (int i = 1; i <= temp; i++)
                {
                    comboBoxSitzplatz.Items.Add("Sitzplatz: " + i);
                }
                
                if (datenbank.FluggastTicketArt.Equals("Festbuchung"))
                {
                    buttonBorderCard.Show();
                    richTextBox.Hide();
                }
                else
                {
                    buttonBorderCard.Hide();
                    richTextBox.Show();
                }
                    
                
                preisCheck = true;
            }
            else
            {
                textBoxFluggastId.Text = "";
                textBoxTicket.Text = "";
                textBoxName.Text = "";
                textBoxTicketArt.Text = "";
                textBoxTicketNummer.Text = "Eingabe fehlerhaft oder Ticket nicht vorhanden!";
                preisCheck = false;
            }
        }

        private void buttonWiegen_Click(object sender, EventArgs e)
        {
            IdentifikationsnummerGen identifikationsnummerGen = new IdentifikationsnummerGen(datenbank.FluggastName, datenbank.Abflughafen, datenbank.Ankunftflughafen, datenbank.FluggastTicket);
            
            if(preisCheck)
            {
                bool toDouble = double.TryParse(datenbank.GebaeckPreis, out preis);
                
                if (toDouble)
                {
                    textBoxWiegen.Text = string.Format("{0:C}", preis);
                    string wiegen = string.Format("Gepäck liegt im Bereich {0} - {1} \n" +
                                                  "und es müssen {2:C} zugezahlt werden \n \n" +
                                                  "Identifkationsnummer: {3} \n" +
                                                  "Flugnummer: {4} \n" +
                                                  "Abflughafen: {5} \n" +
                                                  "Zielflughafen: {6} \n", datenbank.GebeackMind, datenbank.GepeackMax, preis,identifikationsnummerGen.IndNummer , datenbank.FlugNummer,
                        datenbank.Abflughafen, datenbank.Ankunftflughafen);
                    textBoxIdentifkationsnummer.Text = identifikationsnummerGen.IndNummer;
                    datenbank.GebaeckEinchecken(datenbank.FluggastTicket, identifikationsnummerGen.IndNummer);
                    DialogResult dialogResult = MessageBox.Show(wiegen, "Wiegen");
                    labelInfo.Text = "";
                    wiegenCheck = true;
                    
                    if(wiegenCheck)
                    {
                        if (datenbank.FluggastTicketArt.Equals("Festbuchung"))
                            buttonBorderCard.Show();
                        else
                            buttonBorderCard.Hide();
                    }    
                    
                }
                else
                    textBoxWiegen.Text = "Konnte nicht auf Double konventieren";

            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Erst eine TicketId eingeben!", "Fehler!");
            }
            
        }

        private void comboBoxSitzplatz_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSitzplatz.SelectedItem.ToString().Equals(""))
            {
                datenbank.SitzplatzZuweisen(datenbank.FluggastTicket, comboBoxSitzplatz.SelectedItem.ToString());
                sitzplatzCheck = true;
            }
            else
            {
                labelInfo.Text = "Nicht alle Felder ausgefüllt";
                sitzplatzCheck = false;
            }
        }

        private void buttonBorderCard_Click(object sender, EventArgs e)
        {
            BorderCard formBorderCard = new BorderCard();
           

            formBorderCard.Flugnummer = textBoxFlugnummer.Text;
            formBorderCard.NamePass = textBoxName.Text;
            formBorderCard.Sitzplatz = comboBoxSitzplatz.SelectedItem.ToString();
            DialogResult dr = formBorderCard.ShowDialog();
        }

        private void buttonSuS_Click(object sender, EventArgs e)
        {
            if(preisCheck && wiegenCheck && checkBoxPass.Checked)
            {
                labelInfo.Text = "";
            }
            else
            {
                labelInfo.Text = "Nicht alle Felder ausgefüllt!";
            }
        }
    }
}