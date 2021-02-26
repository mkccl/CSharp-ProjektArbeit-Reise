namespace ProjektReise
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.buttonCheckIn = new System.Windows.Forms.Button();
            this.buttonPil = new System.Windows.Forms.Button();
            this.buttonGebaeck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCheckIn
            // 
            this.buttonCheckIn.Location = new System.Drawing.Point(24, 261);
            this.buttonCheckIn.Name = "buttonCheckIn";
            this.buttonCheckIn.Size = new System.Drawing.Size(252, 81);
            this.buttonCheckIn.TabIndex = 0;
            this.buttonCheckIn.Text = "Check-In";
            this.buttonCheckIn.UseVisualStyleBackColor = true;
            this.buttonCheckIn.Click += new System.EventHandler(this.buttonCheckIn_Click);
            // 
            // buttonPil
            // 
            this.buttonPil.Location = new System.Drawing.Point(282, 261);
            this.buttonPil.Name = "buttonPil";
            this.buttonPil.Size = new System.Drawing.Size(252, 81);
            this.buttonPil.TabIndex = 1;
            this.buttonPil.Text = "Passenger Information List (PIL)";
            this.buttonPil.UseVisualStyleBackColor = true;
            this.buttonPil.Click += new System.EventHandler(this.buttonPil_Click);
            // 
            // buttonGebaeck
            // 
            this.buttonGebaeck.Location = new System.Drawing.Point(540, 261);
            this.buttonGebaeck.Name = "buttonGebaeck";
            this.buttonGebaeck.Size = new System.Drawing.Size(252, 81);
            this.buttonGebaeck.TabIndex = 2;
            this.buttonGebaeck.Text = "Gepäckabfertigung";
            this.buttonGebaeck.UseVisualStyleBackColor = true;
            this.buttonGebaeck.Click += new System.EventHandler(this.buttonGebaeck_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(121, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(551, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Programm zum abfertigen von Gästen einer Fluggesellschaft \r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(121, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(551, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "von Michael Krause";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonGebaeck);
            this.Controls.Add(this.buttonPil);
            this.Controls.Add(this.buttonCheckIn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button buttonGebaeck;
        private System.Windows.Forms.Button buttonPil;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button buttonCheckIn;

        #endregion
    }
}