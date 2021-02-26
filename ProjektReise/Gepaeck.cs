using System;
using System.Windows.Forms;

namespace ProjektReise
{
    public partial class Gepaeck : Form
    {
        public Gepaeck()
        {
            InitializeComponent();
        }

        private void buttonAbschicken_Click(object sender, EventArgs e)
        {
            string fliegerOk = "Flieger kann starten";

            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked)
            {
                DialogResult dr = MessageBox.Show(fliegerOk, "OK");
            }
            else
            {
                labelFehler.Text = "Nicht alle CheckBoxen wurden ausgefüllt";
            }
        }
    }
}