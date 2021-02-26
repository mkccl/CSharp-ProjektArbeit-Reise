using System.ComponentModel;

namespace ProjektReise
{
    partial class CheckIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTicketNummer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAuslesen = new System.Windows.Forms.Button();
            this.textBoxFluggastId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTicket = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTicketArt = new System.Windows.Forms.TextBox();
            this.buttonWiegen = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWiegen = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxAnHafen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxAbFlug = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxIdentifkationsnummer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxFlugnummer = new System.Windows.Forms.TextBox();
            this.comboBoxSitzplatz = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonBorderCard = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.checkBoxPass = new System.Windows.Forms.CheckBox();
            this.buttonSuS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxTicketNummer
            // 
            this.textBoxTicketNummer.Location = new System.Drawing.Point(197, 28);
            this.textBoxTicketNummer.Name = "textBoxTicketNummer";
            this.textBoxTicketNummer.Size = new System.Drawing.Size(234, 20);
            this.textBoxTicketNummer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(197, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ticketnummer eingeben";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAuslesen
            // 
            this.buttonAuslesen.Location = new System.Drawing.Point(437, 28);
            this.buttonAuslesen.Name = "buttonAuslesen";
            this.buttonAuslesen.Size = new System.Drawing.Size(80, 21);
            this.buttonAuslesen.TabIndex = 2;
            this.buttonAuslesen.Text = "Auslesen";
            this.buttonAuslesen.UseVisualStyleBackColor = true;
            this.buttonAuslesen.Click += new System.EventHandler(this.buttonAuslesen_Click);
            // 
            // textBoxFluggastId
            // 
            this.textBoxFluggastId.Location = new System.Drawing.Point(294, 111);
            this.textBoxFluggastId.Name = "textBoxFluggastId";
            this.textBoxFluggastId.ReadOnly = true;
            this.textBoxFluggastId.Size = new System.Drawing.Size(276, 20);
            this.textBoxFluggastId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(294, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fluggast ID:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(294, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ticket:";
            // 
            // textBoxTicket
            // 
            this.textBoxTicket.Location = new System.Drawing.Point(294, 160);
            this.textBoxTicket.Name = "textBoxTicket";
            this.textBoxTicket.ReadOnly = true;
            this.textBoxTicket.Size = new System.Drawing.Size(276, 20);
            this.textBoxTicket.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(294, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(294, 213);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(276, 20);
            this.textBoxName.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(294, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 21);
            this.label5.TabIndex = 13;
            this.label5.Text = "Art des Tickets:";
            // 
            // textBoxTicketArt
            // 
            this.textBoxTicketArt.Location = new System.Drawing.Point(294, 267);
            this.textBoxTicketArt.Name = "textBoxTicketArt";
            this.textBoxTicketArt.ReadOnly = true;
            this.textBoxTicketArt.Size = new System.Drawing.Size(276, 20);
            this.textBoxTicketArt.TabIndex = 12;
            // 
            // buttonWiegen
            // 
            this.buttonWiegen.Location = new System.Drawing.Point(609, 79);
            this.buttonWiegen.Name = "buttonWiegen";
            this.buttonWiegen.Size = new System.Drawing.Size(179, 40);
            this.buttonWiegen.TabIndex = 14;
            this.buttonWiegen.Text = "Gepäck wiegen";
            this.buttonWiegen.UseVisualStyleBackColor = true;
            this.buttonWiegen.Click += new System.EventHandler(this.buttonWiegen_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(294, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 21);
            this.label6.TabIndex = 16;
            this.label6.Text = "Zuzahlender Betrag für Gebäck:";
            // 
            // textBoxWiegen
            // 
            this.textBoxWiegen.Location = new System.Drawing.Point(294, 321);
            this.textBoxWiegen.Name = "textBoxWiegen";
            this.textBoxWiegen.ReadOnly = true;
            this.textBoxWiegen.Size = new System.Drawing.Size(276, 20);
            this.textBoxWiegen.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ankunftsflughafen:\r\n";
            // 
            // textBoxAnHafen
            // 
            this.textBoxAnHafen.Location = new System.Drawing.Point(12, 213);
            this.textBoxAnHafen.Name = "textBoxAnHafen";
            this.textBoxAnHafen.ReadOnly = true;
            this.textBoxAnHafen.Size = new System.Drawing.Size(276, 20);
            this.textBoxAnHafen.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(164, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = "Abflughafen:";
            // 
            // textBoxAbFlug
            // 
            this.textBoxAbFlug.Location = new System.Drawing.Point(12, 160);
            this.textBoxAbFlug.Name = "textBoxAbFlug";
            this.textBoxAbFlug.ReadOnly = true;
            this.textBoxAbFlug.Size = new System.Drawing.Size(276, 20);
            this.textBoxAbFlug.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(12, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(164, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Gepäckidentifkationsnummer:\r\n\r\n";
            // 
            // textBoxIdentifkationsnummer
            // 
            this.textBoxIdentifkationsnummer.Location = new System.Drawing.Point(12, 267);
            this.textBoxIdentifkationsnummer.Name = "textBoxIdentifkationsnummer";
            this.textBoxIdentifkationsnummer.ReadOnly = true;
            this.textBoxIdentifkationsnummer.Size = new System.Drawing.Size(276, 20);
            this.textBoxIdentifkationsnummer.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 21);
            this.label11.TabIndex = 24;
            this.label11.Text = "Flugnummer:";
            // 
            // textBoxFlugnummer
            // 
            this.textBoxFlugnummer.Location = new System.Drawing.Point(12, 111);
            this.textBoxFlugnummer.Name = "textBoxFlugnummer";
            this.textBoxFlugnummer.ReadOnly = true;
            this.textBoxFlugnummer.Size = new System.Drawing.Size(276, 20);
            this.textBoxFlugnummer.TabIndex = 23;
            // 
            // comboBoxSitzplatz
            // 
            this.comboBoxSitzplatz.FormattingEnabled = true;
            this.comboBoxSitzplatz.Location = new System.Drawing.Point(12, 321);
            this.comboBoxSitzplatz.Name = "comboBoxSitzplatz";
            this.comboBoxSitzplatz.Size = new System.Drawing.Size(178, 21);
            this.comboBoxSitzplatz.TabIndex = 25;
            this.comboBoxSitzplatz.SelectedIndexChanged += new System.EventHandler(this.comboBoxSitzplatz_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(12, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(164, 21);
            this.label10.TabIndex = 26;
            this.label10.Text = "Sitzplatz im Flieger:";
            // 
            // buttonBorderCard
            // 
            this.buttonBorderCard.Location = new System.Drawing.Point(609, 179);
            this.buttonBorderCard.Name = "buttonBorderCard";
            this.buttonBorderCard.Size = new System.Drawing.Size(179, 83);
            this.buttonBorderCard.TabIndex = 27;
            this.buttonBorderCard.Text = "Border Card";
            this.buttonBorderCard.UseVisualStyleBackColor = true;
            this.buttonBorderCard.Click += new System.EventHandler(this.buttonBorderCard_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(61, 380);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(500, 39);
            this.labelInfo.TabIndex = 28;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(609, 180);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(178, 177);
            this.richTextBox.TabIndex = 29;
            this.richTextBox.Text = "Gepäck wird vorerst nicht verladen da noch nicht feststeht\nob Kunde mitfliegen ka" + "nn.";
            // 
            // checkBoxPass
            // 
            this.checkBoxPass.Location = new System.Drawing.Point(479, 358);
            this.checkBoxPass.Name = "checkBoxPass";
            this.checkBoxPass.Size = new System.Drawing.Size(91, 36);
            this.checkBoxPass.TabIndex = 30;
            this.checkBoxPass.Text = "Passgeprüft?";
            this.checkBoxPass.UseVisualStyleBackColor = true;
            // 
            // buttonSuS
            // 
            this.buttonSuS.Location = new System.Drawing.Point(609, 125);
            this.buttonSuS.Name = "buttonSuS";
            this.buttonSuS.Size = new System.Drawing.Size(179, 40);
            this.buttonSuS.TabIndex = 31;
            this.buttonSuS.Text = "Speichern und Schließen";
            this.buttonSuS.UseVisualStyleBackColor = true;
            this.buttonSuS.Click += new System.EventHandler(this.buttonSuS_Click);
            // 
            // CheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSuS);
            this.Controls.Add(this.checkBoxPass);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonBorderCard);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBoxSitzplatz);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBoxFlugnummer);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxIdentifkationsnummer);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxAnHafen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxAbFlug);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxWiegen);
            this.Controls.Add(this.buttonWiegen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTicketArt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFluggastId);
            this.Controls.Add(this.buttonAuslesen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTicketNummer);
            this.Name = "CheckIn";
            this.Text = "CheckIn";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonSuS;

        private System.Windows.Forms.CheckBox checkBoxPass;

        private System.Windows.Forms.RichTextBox richTextBox;

        private System.Windows.Forms.Label labelInfo;

        private System.Windows.Forms.Button buttonBorderCard;

        private System.Windows.Forms.ComboBox comboBoxSitzplatz;
        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxFlugnummer;

        private System.Windows.Forms.TextBox textBoxIdentifkationsnummer;

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAnHafen;

        private System.Windows.Forms.TextBox textBoxAbFlug;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.TextBox textBoxWiegen;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Button buttonWiegen;

        private System.Windows.Forms.TextBox textBoxTicketArt;

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTicket;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFluggastId;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox textBoxTicketNummer;

        private System.Windows.Forms.Button buttonAuslesen;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}