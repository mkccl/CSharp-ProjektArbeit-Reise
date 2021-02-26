using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektReise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheckIn_Click(object sender, EventArgs e)
        {
            // Checkin Form erstellen
            CheckIn checkIn = new CheckIn();
            checkIn.ShowDialog();
        }

        private void buttonPil_Click(object sender, EventArgs e)
        {
            // PIL Form erstellen
            Pil pil = new Pil();
            pil.ShowDialog();
        }

        private void buttonGebaeck_Click(object sender, EventArgs e)
        {
            
            Gepaeck gepaeck = new Gepaeck();
            gepaeck.ShowDialog();
        }
    }
}