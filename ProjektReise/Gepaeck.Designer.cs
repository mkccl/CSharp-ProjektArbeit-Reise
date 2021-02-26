using System.ComponentModel;

namespace ProjektReise
{
    partial class Gepaeck
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.labelFehler = new System.Windows.Forms.Label();
            this.buttonAbschicken = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(83, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(642, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checkliste für Gepäck";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(95, 132);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(371, 44);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Passagiere durchgezählt?";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(95, 168);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(371, 44);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "PIL übergeben?";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(95, 209);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(371, 44);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Gepäck wurde verladen?";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // labelFehler
            // 
            this.labelFehler.Location = new System.Drawing.Point(83, 315);
            this.labelFehler.Name = "labelFehler";
            this.labelFehler.Size = new System.Drawing.Size(642, 38);
            this.labelFehler.TabIndex = 4;
            this.labelFehler.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonAbschicken
            // 
            this.buttonAbschicken.Location = new System.Drawing.Point(533, 157);
            this.buttonAbschicken.Name = "buttonAbschicken";
            this.buttonAbschicken.Size = new System.Drawing.Size(225, 65);
            this.buttonAbschicken.TabIndex = 5;
            this.buttonAbschicken.Text = "Abschicken";
            this.buttonAbschicken.UseVisualStyleBackColor = true;
            this.buttonAbschicken.Click += new System.EventHandler(this.buttonAbschicken_Click);
            // 
            // Gepaeck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAbschicken);
            this.Controls.Add(this.labelFehler);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "Gepaeck";
            this.Text = "Gepaeck";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonAbschicken;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label labelFehler;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}