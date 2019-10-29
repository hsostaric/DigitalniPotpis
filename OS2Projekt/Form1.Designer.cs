namespace OS2Projekt
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.uiTekstZaKriptiranje = new System.Windows.Forms.TextBox();
            this.uiAESKriptiranje = new System.Windows.Forms.Button();
            this.uiKriptiraniTekst = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uiAESDekriptiranje = new System.Windows.Forms.Button();
            this.uiRSAKriptiranje = new System.Windows.Forms.Button();
            this.uiRSADekriptiraj = new System.Windows.Forms.Button();
            this.uiSazetak = new System.Windows.Forms.Button();
            this.uiDigitalniPotpis = new System.Windows.Forms.Button();
            this.uiProvijeriDigitalni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uiTekstZaKriptiranje
            // 
            this.uiTekstZaKriptiranje.Location = new System.Drawing.Point(29, 83);
            this.uiTekstZaKriptiranje.Multiline = true;
            this.uiTekstZaKriptiranje.Name = "uiTekstZaKriptiranje";
            this.uiTekstZaKriptiranje.Size = new System.Drawing.Size(283, 351);
            this.uiTekstZaKriptiranje.TabIndex = 0;
            // 
            // uiAESKriptiranje
            // 
            this.uiAESKriptiranje.Location = new System.Drawing.Point(29, 35);
            this.uiAESKriptiranje.Name = "uiAESKriptiranje";
            this.uiAESKriptiranje.Size = new System.Drawing.Size(99, 42);
            this.uiAESKriptiranje.TabIndex = 1;
            this.uiAESKriptiranje.Text = "AES kriptiranje";
            this.uiAESKriptiranje.UseVisualStyleBackColor = true;
            this.uiAESKriptiranje.Click += new System.EventHandler(this.uiAESKriptiranje_Click);
            // 
            // uiKriptiraniTekst
            // 
            this.uiKriptiraniTekst.Location = new System.Drawing.Point(433, 83);
            this.uiKriptiraniTekst.Multiline = true;
            this.uiKriptiraniTekst.Name = "uiKriptiraniTekst";
            this.uiKriptiraniTekst.Size = new System.Drawing.Size(275, 351);
            this.uiKriptiraniTekst.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 448);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nekriptirani tekst";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kriptirani tekst";
            // 
            // uiAESDekriptiranje
            // 
            this.uiAESDekriptiranje.Location = new System.Drawing.Point(365, 35);
            this.uiAESDekriptiranje.Name = "uiAESDekriptiranje";
            this.uiAESDekriptiranje.Size = new System.Drawing.Size(102, 42);
            this.uiAESDekriptiranje.TabIndex = 5;
            this.uiAESDekriptiranje.Text = "AES dekriptiraj";
            this.uiAESDekriptiranje.UseVisualStyleBackColor = true;
            this.uiAESDekriptiranje.Click += new System.EventHandler(this.uiAESDekriptiranje_Click);
            // 
            // uiRSAKriptiranje
            // 
            this.uiRSAKriptiranje.Location = new System.Drawing.Point(163, 35);
            this.uiRSAKriptiranje.Name = "uiRSAKriptiranje";
            this.uiRSAKriptiranje.Size = new System.Drawing.Size(109, 42);
            this.uiRSAKriptiranje.TabIndex = 6;
            this.uiRSAKriptiranje.Text = "RSA kriptiranje";
            this.uiRSAKriptiranje.UseVisualStyleBackColor = true;
            this.uiRSAKriptiranje.Click += new System.EventHandler(this.uiRSAKriptiranje_Click);
            // 
            // uiRSADekriptiraj
            // 
            this.uiRSADekriptiraj.Location = new System.Drawing.Point(486, 35);
            this.uiRSADekriptiraj.Name = "uiRSADekriptiraj";
            this.uiRSADekriptiraj.Size = new System.Drawing.Size(113, 42);
            this.uiRSADekriptiraj.TabIndex = 7;
            this.uiRSADekriptiraj.Text = "RSA dekriptiraj";
            this.uiRSADekriptiraj.UseVisualStyleBackColor = true;
            this.uiRSADekriptiraj.Click += new System.EventHandler(this.uiRSADekriptiraj_Click);
            // 
            // uiSazetak
            // 
            this.uiSazetak.Location = new System.Drawing.Point(621, 35);
            this.uiSazetak.Name = "uiSazetak";
            this.uiSazetak.Size = new System.Drawing.Size(103, 42);
            this.uiSazetak.TabIndex = 8;
            this.uiSazetak.Text = "Izracunaj sažetak";
            this.uiSazetak.UseVisualStyleBackColor = true;
            this.uiSazetak.Click += new System.EventHandler(this.uiSazetak_Click);
            // 
            // uiDigitalniPotpis
            // 
            this.uiDigitalniPotpis.Location = new System.Drawing.Point(748, 32);
            this.uiDigitalniPotpis.Name = "uiDigitalniPotpis";
            this.uiDigitalniPotpis.Size = new System.Drawing.Size(116, 49);
            this.uiDigitalniPotpis.TabIndex = 9;
            this.uiDigitalniPotpis.Text = "Digitalno potpiši ulaznu datoteku";
            this.uiDigitalniPotpis.UseVisualStyleBackColor = true;
            this.uiDigitalniPotpis.Click += new System.EventHandler(this.uiDigitalniPotpis_Click);
            // 
            // uiProvijeriDigitalni
            // 
            this.uiProvijeriDigitalni.Location = new System.Drawing.Point(882, 33);
            this.uiProvijeriDigitalni.Name = "uiProvijeriDigitalni";
            this.uiProvijeriDigitalni.Size = new System.Drawing.Size(127, 46);
            this.uiProvijeriDigitalni.TabIndex = 10;
            this.uiProvijeriDigitalni.Text = "Provijeri potpis";
            this.uiProvijeriDigitalni.UseVisualStyleBackColor = true;
            this.uiProvijeriDigitalni.Click += new System.EventHandler(this.uiProvijeriDigitalni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 481);
            this.Controls.Add(this.uiProvijeriDigitalni);
            this.Controls.Add(this.uiDigitalniPotpis);
            this.Controls.Add(this.uiSazetak);
            this.Controls.Add(this.uiRSADekriptiraj);
            this.Controls.Add(this.uiRSAKriptiranje);
            this.Controls.Add(this.uiAESDekriptiranje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiKriptiraniTekst);
            this.Controls.Add(this.uiAESKriptiranje);
            this.Controls.Add(this.uiTekstZaKriptiranje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uiTekstZaKriptiranje;
        private System.Windows.Forms.Button uiAESKriptiranje;
        private System.Windows.Forms.TextBox uiKriptiraniTekst;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button uiAESDekriptiranje;
        private System.Windows.Forms.Button uiRSAKriptiranje;
        private System.Windows.Forms.Button uiRSADekriptiraj;
        private System.Windows.Forms.Button uiSazetak;
        private System.Windows.Forms.Button uiDigitalniPotpis;
        private System.Windows.Forms.Button uiProvijeriDigitalni;
    }
}

