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
            this.stationLabel = new System.Windows.Forms.Label();
            this.stationTextBox = new System.Windows.Forms.TextBox();
            this.verbindungAnzBttn = new System.Windows.Forms.Button();
            this.vonStationlistBox = new System.Windows.Forms.ListBox();
            this.nachStationlistBox = new System.Windows.Forms.ListBox();
            this.datumBox = new System.Windows.Forms.DateTimePicker();
            this.datumLabel = new System.Windows.Forms.Label();
            this.uhrzeitLabel = new System.Windows.Forms.Label();
            this.uhrzeitBox = new System.Windows.Forms.TextBox();
            this.stationGroupBox = new System.Windows.Forms.GroupBox();
            this.stationListBox = new System.Windows.Forms.ListBox();
            this.verbindungGroupBox = new System.Windows.Forms.GroupBox();
            this.fahrplanLabel = new System.Windows.Forms.Label();
            this.stationGroupBox.SuspendLayout();
            this.verbindungGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // vonLabel
            // 
            this.vonLabel.AutoSize = true;
            this.vonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vonLabel.Location = new System.Drawing.Point(6, 29);
            this.vonLabel.Name = "vonLabel";
            this.vonLabel.Size = new System.Drawing.Size(42, 20);
            this.vonLabel.TabIndex = 0;
            this.vonLabel.Text = "Von:";
            // 
            // nachLabel
            // 
            this.nachLabel.AutoSize = true;
            this.nachLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nachLabel.Location = new System.Drawing.Point(311, 29);
            this.nachLabel.Name = "nachLabel";
            this.nachLabel.Size = new System.Drawing.Size(50, 20);
            this.nachLabel.TabIndex = 1;
            this.nachLabel.Text = "Nach:";
            // 
            // vonTextBox
            // 
            this.vonTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vonTextBox.Location = new System.Drawing.Point(10, 52);
            this.vonTextBox.Name = "vonTextBox";
            this.vonTextBox.Size = new System.Drawing.Size(254, 26);
            this.vonTextBox.TabIndex = 2;
            this.vonTextBox.TextChanged += new System.EventHandler(this.vonTextBox_TextChanged);
            // 
            // nachTextBox
            // 
            this.nachTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nachTextBox.Location = new System.Drawing.Point(315, 52);
            this.nachTextBox.Name = "nachTextBox";
            this.nachTextBox.Size = new System.Drawing.Size(246, 26);
            this.nachTextBox.TabIndex = 3;
            this.nachTextBox.TextChanged += new System.EventHandler(this.nachTextBox_TextChanged);
            // 
            // suchtVerbindungBttn
            // 
            this.suchtVerbindungBttn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.suchtVerbindungBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.suchtVerbindungBttn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.suchtVerbindungBttn.Location = new System.Drawing.Point(6, 316);
            this.suchtVerbindungBttn.Name = "suchtVerbindungBttn";
            this.suchtVerbindungBttn.Size = new System.Drawing.Size(555, 98);
            this.suchtVerbindungBttn.TabIndex = 4;
            this.suchtVerbindungBttn.Text = "Verbindung suchen ->";
            this.suchtVerbindungBttn.UseVisualStyleBackColor = false;
            this.suchtVerbindungBttn.Click += new System.EventHandler(this.suchtVerbindungBttn_Click);
            // 
            // stationLabel
            // 
            this.stationLabel.AutoSize = true;
            this.stationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationLabel.Location = new System.Drawing.Point(16, 29);
            this.stationLabel.Name = "stationLabel";
            this.stationLabel.Size = new System.Drawing.Size(64, 20);
            this.stationLabel.TabIndex = 9;
            this.stationLabel.Text = "Station:";
            // 
            // stationTextBox
            // 
            this.stationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationTextBox.Location = new System.Drawing.Point(20, 52);
            this.stationTextBox.Name = "stationTextBox";
            this.stationTextBox.Size = new System.Drawing.Size(254, 26);
            this.stationTextBox.TabIndex = 10;
            this.stationTextBox.TextChanged += new System.EventHandler(this.stationTextBox_TextChanged);
            // 
            // verbindungAnzBttn
            // 
            this.verbindungAnzBttn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.verbindungAnzBttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verbindungAnzBttn.Location = new System.Drawing.Point(20, 316);
            this.verbindungAnzBttn.Name = "verbindungAnzBttn";
            this.verbindungAnzBttn.Size = new System.Drawing.Size(254, 98);
            this.verbindungAnzBttn.TabIndex = 11;
            this.verbindungAnzBttn.Text = "Verbindungen anzeigen ";
            this.verbindungAnzBttn.UseVisualStyleBackColor = false;
            this.verbindungAnzBttn.Click += new System.EventHandler(this.verbindungAnzBttn_Click);
            // 
            // vonStationlistBox
            // 
            this.vonStationlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vonStationlistBox.FormattingEnabled = true;
            this.vonStationlistBox.ItemHeight = 20;
            this.vonStationlistBox.Location = new System.Drawing.Point(10, 84);
            this.vonStationlistBox.Name = "vonStationlistBox";
            this.vonStationlistBox.Size = new System.Drawing.Size(254, 124);
            this.vonStationlistBox.TabIndex = 13;
            this.vonStationlistBox.DoubleClick += new System.EventHandler(this.vonStationlistBox_DoubleClick);
            // 
            // nachStationlistBox
            // 
            this.nachStationlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nachStationlistBox.FormattingEnabled = true;
            this.nachStationlistBox.ItemHeight = 20;
            this.nachStationlistBox.Location = new System.Drawing.Point(315, 84);
            this.nachStationlistBox.Name = "nachStationlistBox";
            this.nachStationlistBox.Size = new System.Drawing.Size(246, 124);
            this.nachStationlistBox.TabIndex = 14;
            this.nachStationlistBox.DoubleClick += new System.EventHandler(this.nachStationlistBox_DoubleClick);
            // 
            // datumBox
            // 
            this.datumBox.CustomFormat = "MM:dd:yyyy";
            this.datumBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datumBox.Location = new System.Drawing.Point(315, 257);
            this.datumBox.Name = "datumBox";
            this.datumBox.Size = new System.Drawing.Size(246, 26);
            this.datumBox.TabIndex = 15;
            // 
            // datumLabel
            // 
            this.datumLabel.AutoSize = true;
            this.datumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datumLabel.Location = new System.Drawing.Point(311, 234);
            this.datumLabel.Name = "datumLabel";
            this.datumLabel.Size = new System.Drawing.Size(61, 20);
            this.datumLabel.TabIndex = 17;
            this.datumLabel.Text = "Datum:";
            // 
            // uhrzeitLabel
            // 
            this.uhrzeitLabel.AutoSize = true;
            this.uhrzeitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uhrzeitLabel.Location = new System.Drawing.Point(6, 234);
            this.uhrzeitLabel.Name = "uhrzeitLabel";
            this.uhrzeitLabel.Size = new System.Drawing.Size(64, 20);
            this.uhrzeitLabel.TabIndex = 18;
            this.uhrzeitLabel.Text = "Uhrzeit:";
            // 
            // uhrzeitBox
            // 
            this.uhrzeitBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uhrzeitBox.Location = new System.Drawing.Point(10, 257);
            this.uhrzeitBox.Name = "uhrzeitBox";
            this.uhrzeitBox.Size = new System.Drawing.Size(254, 26);
            this.uhrzeitBox.TabIndex = 19;
            // 
            // stationGroupBox
            // 
            this.stationGroupBox.Controls.Add(this.stationListBox);
            this.stationGroupBox.Controls.Add(this.stationLabel);
            this.stationGroupBox.Controls.Add(this.stationTextBox);
            this.stationGroupBox.Controls.Add(this.verbindungAnzBttn);
            this.stationGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationGroupBox.Location = new System.Drawing.Point(596, 71);
            this.stationGroupBox.Name = "stationGroupBox";
            this.stationGroupBox.Size = new System.Drawing.Size(289, 421);
            this.stationGroupBox.TabIndex = 20;
            this.stationGroupBox.TabStop = false;
            this.stationGroupBox.Text = "Stationen:";
            // 
            // stationListBox
            // 
            this.stationListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationListBox.FormattingEnabled = true;
            this.stationListBox.ItemHeight = 20;
            this.stationListBox.Location = new System.Drawing.Point(20, 84);
            this.stationListBox.Name = "stationListBox";
            this.stationListBox.Size = new System.Drawing.Size(254, 124);
            this.stationListBox.TabIndex = 12;
            this.stationListBox.DoubleClick += new System.EventHandler(this.stationListBox_DoubleClick);
            // 
            // verbindungGroupBox
            // 
            this.verbindungGroupBox.Controls.Add(this.vonTextBox);
            this.verbindungGroupBox.Controls.Add(this.vonLabel);
            this.verbindungGroupBox.Controls.Add(this.uhrzeitBox);
            this.verbindungGroupBox.Controls.Add(this.nachLabel);
            this.verbindungGroupBox.Controls.Add(this.uhrzeitLabel);
            this.verbindungGroupBox.Controls.Add(this.nachTextBox);
            this.verbindungGroupBox.Controls.Add(this.datumLabel);
            this.verbindungGroupBox.Controls.Add(this.suchtVerbindungBttn);
            this.verbindungGroupBox.Controls.Add(this.datumBox);
            this.verbindungGroupBox.Controls.Add(this.vonStationlistBox);
            this.verbindungGroupBox.Controls.Add(this.nachStationlistBox);
            this.verbindungGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verbindungGroupBox.Location = new System.Drawing.Point(12, 71);
            this.verbindungGroupBox.Name = "verbindungGroupBox";
            this.verbindungGroupBox.Size = new System.Drawing.Size(568, 421);
            this.verbindungGroupBox.TabIndex = 21;
            this.verbindungGroupBox.TabStop = false;
            this.verbindungGroupBox.Text = "Verbindungen:";
            // 
            // fahrplanLabel
            // 
            this.fahrplanLabel.AutoSize = true;
            this.fahrplanLabel.BackColor = System.Drawing.SystemColors.Control;
            this.fahrplanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrplanLabel.Location = new System.Drawing.Point(265, 9);
            this.fahrplanLabel.Name = "fahrplanLabel";
            this.fahrplanLabel.Size = new System.Drawing.Size(347, 52);
            this.fahrplanLabel.TabIndex = 22;
            this.fahrplanLabel.Text = "Fahrplan BBZW";
            // 
            // fahrplanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 497);
            this.Controls.Add(this.fahrplanLabel);
            this.Controls.Add(this.verbindungGroupBox);
            this.Controls.Add(this.stationGroupBox);
            this.Name = "fahrplanForm";
            this.Text = "ÖV-Plan";
            this.Load += new System.EventHandler(this.fahrplanForm_Load);
            this.stationGroupBox.ResumeLayout(false);
            this.stationGroupBox.PerformLayout();
            this.verbindungGroupBox.ResumeLayout(false);
            this.verbindungGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label vonLabel;
        private System.Windows.Forms.Label nachLabel;
        private System.Windows.Forms.TextBox vonTextBox;
        private System.Windows.Forms.TextBox nachTextBox;
        private System.Windows.Forms.Button suchtVerbindungBttn;
        private System.Windows.Forms.Label stationLabel;
        private System.Windows.Forms.TextBox stationTextBox;
        private System.Windows.Forms.Button verbindungAnzBttn;
        private System.Windows.Forms.ListBox vonStationlistBox;
        private System.Windows.Forms.ListBox nachStationlistBox;
        private System.Windows.Forms.DateTimePicker datumBox;
        private System.Windows.Forms.Label datumLabel;
        private System.Windows.Forms.Label uhrzeitLabel;
        private System.Windows.Forms.TextBox uhrzeitBox;
        private System.Windows.Forms.GroupBox stationGroupBox;
        private System.Windows.Forms.GroupBox verbindungGroupBox;
        private System.Windows.Forms.ListBox stationListBox;
        private System.Windows.Forms.Label fahrplanLabel;
    }
}

