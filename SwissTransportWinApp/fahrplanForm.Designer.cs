namespace SwissTransportWinApp
{
    partial class fahrplanForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.vonLabel = new System.Windows.Forms.Label();
            this.nachLabel = new System.Windows.Forms.Label();
            this.vonTextBox = new System.Windows.Forms.TextBox();
            this.nachTextBox = new System.Windows.Forms.TextBox();
            this.suchtVerbindungBttn = new System.Windows.Forms.Button();
            this.zeitLabel = new System.Windows.Forms.Label();
            this.datumLabel = new System.Windows.Forms.Label();
            this.zeitTextBox = new System.Windows.Forms.TextBox();
            this.datumTextBox = new System.Windows.Forms.TextBox();
            this.stationLabel = new System.Windows.Forms.Label();
            this.stationTextBox = new System.Windows.Forms.TextBox();
            this.verbindungAnzBttn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // vonLabel
            // 
            this.vonLabel.AutoSize = true;
            this.vonLabel.Location = new System.Drawing.Point(12, 23);
            this.vonLabel.Name = "vonLabel";
            this.vonLabel.Size = new System.Drawing.Size(42, 20);
            this.vonLabel.TabIndex = 0;
            this.vonLabel.Text = "Von:";
            this.vonLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // nachLabel
            // 
            this.nachLabel.AutoSize = true;
            this.nachLabel.Location = new System.Drawing.Point(255, 23);
            this.nachLabel.Name = "nachLabel";
            this.nachLabel.Size = new System.Drawing.Size(50, 20);
            this.nachLabel.TabIndex = 1;
            this.nachLabel.Text = "Nach:";
            // 
            // vonTextBox
            // 
            this.vonTextBox.Location = new System.Drawing.Point(16, 46);
            this.vonTextBox.Name = "vonTextBox";
            this.vonTextBox.Size = new System.Drawing.Size(198, 26);
            this.vonTextBox.TabIndex = 2;
            this.vonTextBox.TextChanged += new System.EventHandler(this.vonTextBox_TextChanged);
            // 
            // nachTextBox
            // 
            this.nachTextBox.Location = new System.Drawing.Point(259, 46);
            this.nachTextBox.Name = "nachTextBox";
            this.nachTextBox.Size = new System.Drawing.Size(209, 26);
            this.nachTextBox.TabIndex = 3;
            this.nachTextBox.TextChanged += new System.EventHandler(this.nachTextBox_TextChanged);
            // 
            // suchtVerbindungBttn
            // 
            this.suchtVerbindungBttn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.suchtVerbindungBttn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.suchtVerbindungBttn.Location = new System.Drawing.Point(140, 168);
            this.suchtVerbindungBttn.Name = "suchtVerbindungBttn";
            this.suchtVerbindungBttn.Size = new System.Drawing.Size(193, 57);
            this.suchtVerbindungBttn.TabIndex = 4;
            this.suchtVerbindungBttn.Text = "Verbindung suchen ->";
            this.suchtVerbindungBttn.UseVisualStyleBackColor = false;
            this.suchtVerbindungBttn.Click += new System.EventHandler(this.suchtVerbindungBttn_Click);
            // 
            // zeitLabel
            // 
            this.zeitLabel.AutoSize = true;
            this.zeitLabel.Location = new System.Drawing.Point(255, 99);
            this.zeitLabel.Name = "zeitLabel";
            this.zeitLabel.Size = new System.Drawing.Size(40, 20);
            this.zeitLabel.TabIndex = 5;
            this.zeitLabel.Text = "Zeit:";
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Location = new System.Drawing.Point(12, 99);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(61, 20);
            this.datumLabel.TabIndex = 6;
            this.datumLabel.Text = "Datum:";
            // 
            // zeitTextBox
            // 
            this.zeitTextBox.Location = new System.Drawing.Point(259, 122);
            this.zeitTextBox.Name = "zeitTextBox";
            this.zeitTextBox.Size = new System.Drawing.Size(209, 26);
            this.zeitTextBox.TabIndex = 7;
            // 
            // datumTextBox
            // 
            this.datumTextBox.Location = new System.Drawing.Point(16, 122);
            this.datumTextBox.Name = "datumTextBox";
            this.datumTextBox.Size = new System.Drawing.Size(198, 26);
            this.datumTextBox.TabIndex = 8;
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Location = new System.Drawing.Point(12, 288);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(64, 20);
            this.stationLabel.TabIndex = 9;
            this.stationLabel.Text = "Station:";
            // 
            // stationTextBox
            // 
            this.stationTextBox.Location = new System.Drawing.Point(12, 311);
            this.stationTextBox.Name = "stationTextBox";
            this.stationTextBox.Size = new System.Drawing.Size(190, 26);
            this.stationTextBox.TabIndex = 10;
            this.stationTextBox.TextChanged += new System.EventHandler(this.stationTextBox_TextChanged);
            // 
            // verbindungAnzBttn
            // 
            this.verbindungAnzBttn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.verbindungAnzBttn.Location = new System.Drawing.Point(228, 298);
            this.verbindungAnzBttn.Name = "verbindungAnzBttn";
            this.verbindungAnzBttn.Size = new System.Drawing.Size(213, 53);
            this.verbindungAnzBttn.TabIndex = 11;
            this.verbindungAnzBttn.Text = "Verbindungen anzeigen ";
            this.verbindungAnzBttn.UseVisualStyleBackColor = false;
            this.verbindungAnzBttn.Click += new System.EventHandler(this.verbindungAnzBttn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(548, 224);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(517, 284);
            this.listBox1.TabIndex = 12;
            // 
            // fahrplanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 597);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.verbindungAnzBttn);
            this.Controls.Add(this.stationTextBox);
            this.Controls.Add(this.stationLabel);
            this.Controls.Add(this.datumTextBox);
            this.Controls.Add(this.zeitTextBox);
            this.Controls.Add(this.datumLabel);
            this.Controls.Add(this.zeitLabel);
            this.Controls.Add(this.suchtVerbindungBttn);
            this.Controls.Add(this.nachTextBox);
            this.Controls.Add(this.vonTextBox);
            this.Controls.Add(this.nachLabel);
            this.Controls.Add(this.vonLabel);
            this.Name = "fahrplanForm";
            this.Text = "ÖV-Plan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vonLabel;
        private System.Windows.Forms.Label nachLabel;
        private System.Windows.Forms.TextBox vonTextBox;
        private System.Windows.Forms.TextBox nachTextBox;
        private System.Windows.Forms.Button suchtVerbindungBttn;
        private System.Windows.Forms.Label zeitLabel;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.TextBox zeitTextBox;
        private System.Windows.Forms.TextBox datumTextBox;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.TextBox stationTextBox;
        private System.Windows.Forms.Button verbindungAnzBttn;
        private System.Windows.Forms.ListBox listBox1;
    }
}

