using System.ComponentModel;

namespace ProjektReise
{
    partial class Pil
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
            this.textBoxAuslesen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAuslesen = new System.Windows.Forms.Button();
            this.pilList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.PLZ = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxAuslesen
            // 
            this.textBoxAuslesen.Location = new System.Drawing.Point(205, 44);
            this.textBoxAuslesen.Name = "textBoxAuslesen";
            this.textBoxAuslesen.Size = new System.Drawing.Size(341, 20);
            this.textBoxAuslesen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(288, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Flugnummer eingeben:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // buttonAuslesen
            // 
            this.buttonAuslesen.Location = new System.Drawing.Point(585, 31);
            this.buttonAuslesen.Name = "buttonAuslesen";
            this.buttonAuslesen.Size = new System.Drawing.Size(137, 32);
            this.buttonAuslesen.TabIndex = 2;
            this.buttonAuslesen.Text = "Auslesen";
            this.buttonAuslesen.UseVisualStyleBackColor = true;
            this.buttonAuslesen.Click += new System.EventHandler(this.buttonAuslesen_Click);
            // 
            // pilList
            // 
            this.pilList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader1, this.columnHeader2, this.PLZ, this.columnHeader4, this.columnHeader3, this.columnHeader5, this.columnHeader6, this.columnHeader7, this.columnHeader8});
            this.pilList.FullRowSelect = true;
            this.pilList.GridLines = true;
            this.pilList.HideSelection = false;
            this.pilList.Location = new System.Drawing.Point(48, 99);
            this.pilList.Margin = new System.Windows.Forms.Padding(2);
            this.pilList.Name = "pilList";
            this.pilList.Size = new System.Drawing.Size(864, 261);
            this.pilList.TabIndex = 12;
            this.pilList.UseCompatibleStateImageBehavior = false;
            this.pilList.View = System.Windows.Forms.View.Details;
            this.pilList.SelectedIndexChanged += new System.EventHandler(this.pilList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ticket ID";
            this.columnHeader1.Width = 58;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Passenger ID";
            this.columnHeader2.Width = 78;
            // 
            // PLZ
            // 
            this.PLZ.Text = "Passenger Ticket";
            this.PLZ.Width = 98;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Abflug-";
            this.columnHeader4.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ankuftflughafen";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Gepäckidentifikationsnummer";
            this.columnHeader5.Width = 153;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Flugnummer";
            this.columnHeader6.Width = 76;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Sitzplatz";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Flugzeugname";
            this.columnHeader8.Width = 100;
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Location = new System.Drawing.Point(742, 31);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(137, 32);
            this.buttonLoeschen.TabIndex = 13;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // Pil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.pilList);
            this.Controls.Add(this.buttonAuslesen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAuslesen);
            this.Name = "Pil";
            this.Text = "Pil";
            this.Load += new System.EventHandler(this.Pil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button buttonLoeschen;

        private System.Windows.Forms.ColumnHeader columnHeader8;

        private System.Windows.Forms.ListView pilList;

        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader PLZ;

        private System.Windows.Forms.TextBox textBoxAuslesen;

        private System.Windows.Forms.Button buttonAuslesen;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}