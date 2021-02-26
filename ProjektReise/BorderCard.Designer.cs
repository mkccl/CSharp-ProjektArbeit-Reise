using System.ComponentModel;

namespace ProjektReise
{
    partial class BorderCard
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
            this.textBoxBorderCardName = new System.Windows.Forms.TextBox();
            this.textBCname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBorderCardFlugnummer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBorderCardSitzplatz = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBorderCardGate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxBorderCardBorderZeit = new System.Windows.Forms.TextBox();
            this.buttonBorderCardDrucken = new System.Windows.Forms.Button();
            this.buttonBorderCardSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxBorderCardName
            // 
            this.textBoxBorderCardName.Location = new System.Drawing.Point(51, 55);
            this.textBoxBorderCardName.Name = "textBoxBorderCardName";
            this.textBoxBorderCardName.ReadOnly = true;
            this.textBoxBorderCardName.Size = new System.Drawing.Size(194, 20);
            this.textBoxBorderCardName.TabIndex = 0;
            // 
            // textBCname
            // 
            this.textBCname.Location = new System.Drawing.Point(51, 30);
            this.textBCname.Name = "textBCname";
            this.textBCname.Size = new System.Drawing.Size(110, 22);
            this.textBCname.TabIndex = 1;
            this.textBCname.Text = "Name:";
            this.textBCname.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(51, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Flugnummer:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxBorderCardFlugnummer
            // 
            this.textBoxBorderCardFlugnummer.Location = new System.Drawing.Point(51, 159);
            this.textBoxBorderCardFlugnummer.Name = "textBoxBorderCardFlugnummer";
            this.textBoxBorderCardFlugnummer.ReadOnly = true;
            this.textBoxBorderCardFlugnummer.Size = new System.Drawing.Size(194, 20);
            this.textBoxBorderCardFlugnummer.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(51, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sitzplatz:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxBorderCardSitzplatz
            // 
            this.textBoxBorderCardSitzplatz.Location = new System.Drawing.Point(51, 109);
            this.textBoxBorderCardSitzplatz.Name = "textBoxBorderCardSitzplatz";
            this.textBoxBorderCardSitzplatz.ReadOnly = true;
            this.textBoxBorderCardSitzplatz.Size = new System.Drawing.Size(194, 20);
            this.textBoxBorderCardSitzplatz.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(51, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Gate:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxBorderCardGate
            // 
            this.textBoxBorderCardGate.Location = new System.Drawing.Point(51, 208);
            this.textBoxBorderCardGate.Name = "textBoxBorderCardGate";
            this.textBoxBorderCardGate.ReadOnly = true;
            this.textBoxBorderCardGate.Size = new System.Drawing.Size(194, 20);
            this.textBoxBorderCardGate.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(51, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Border Zeit:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // textBoxBorderCardBorderZeit
            // 
            this.textBoxBorderCardBorderZeit.Location = new System.Drawing.Point(51, 256);
            this.textBoxBorderCardBorderZeit.Name = "textBoxBorderCardBorderZeit";
            this.textBoxBorderCardBorderZeit.ReadOnly = true;
            this.textBoxBorderCardBorderZeit.Size = new System.Drawing.Size(194, 20);
            this.textBoxBorderCardBorderZeit.TabIndex = 12;
            // 
            // buttonBorderCardDrucken
            // 
            this.buttonBorderCardDrucken.Location = new System.Drawing.Point(290, 100);
            this.buttonBorderCardDrucken.Name = "buttonBorderCardDrucken";
            this.buttonBorderCardDrucken.Size = new System.Drawing.Size(172, 36);
            this.buttonBorderCardDrucken.TabIndex = 14;
            this.buttonBorderCardDrucken.Text = "Drucken";
            this.buttonBorderCardDrucken.UseVisualStyleBackColor = true;
            // 
            // buttonBorderCardSpeichern
            // 
            this.buttonBorderCardSpeichern.Location = new System.Drawing.Point(290, 159);
            this.buttonBorderCardSpeichern.Name = "buttonBorderCardSpeichern";
            this.buttonBorderCardSpeichern.Size = new System.Drawing.Size(172, 36);
            this.buttonBorderCardSpeichern.TabIndex = 15;
            this.buttonBorderCardSpeichern.Text = "Speichern";
            this.buttonBorderCardSpeichern.UseVisualStyleBackColor = true;
            this.buttonBorderCardSpeichern.Click += new System.EventHandler(this.buttonBorderCardSpeichern_Click);
            // 
            // BorderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 316);
            this.Controls.Add(this.buttonBorderCardSpeichern);
            this.Controls.Add(this.buttonBorderCardDrucken);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxBorderCardBorderZeit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBorderCardGate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxBorderCardSitzplatz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBorderCardFlugnummer);
            this.Controls.Add(this.textBCname);
            this.Controls.Add(this.textBoxBorderCardName);
            this.Name = "BorderCard";
            this.Text = "BorderCard";
            this.Load += new System.EventHandler(this.BorderCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonBorderCardSpeichern;

        private System.Windows.Forms.Button buttonBorderCardDrucken;
        private System.Windows.Forms.TextBox textBoxBorderCardBorderZeit;

        private System.Windows.Forms.TextBox textBoxBorderCardGate;

        private System.Windows.Forms.TextBox textBoxBorderCardSitzplatz;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox textBoxBorderCardFlugnummer;
        private System.Windows.Forms.TextBox textBoxBorderCardName;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label textBCname;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}