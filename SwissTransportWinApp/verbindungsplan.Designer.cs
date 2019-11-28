namespace SwissTransportWinApp
{
    partial class verbindungsplan
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
            this.VerbindungenLabel = new System.Windows.Forms.Label();
            this.abfahrtLabel = new System.Windows.Forms.Label();
            this.ankunftLabel = new System.Windows.Forms.Label();
            this.dauerLabel = new System.Windows.Forms.Label();
            this.abfahrtTextBox = new System.Windows.Forms.TextBox();
            this.ankunftTextBox = new System.Windows.Forms.TextBox();
            this.dauerTextBox = new System.Windows.Forms.TextBox();
            this.verbindungListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // VerbindungenLabel
            // 
            this.VerbindungenLabel.AutoSize = true;
            this.VerbindungenLabel.Location = new System.Drawing.Point(208, 24);
            this.VerbindungenLabel.Name = "VerbindungenLabel";
            this.VerbindungenLabel.Size = new System.Drawing.Size(109, 20);
            this.VerbindungenLabel.TabIndex = 0;
            this.VerbindungenLabel.Text = "Verbindungen";
            this.VerbindungenLabel.Click += new System.EventHandler(this.VerbindungenLabel_Click);
            // 
            // abfahrtLabel
            // 
            this.abfahrtLabel.AutoSize = true;
            this.abfahrtLabel.Location = new System.Drawing.Point(46, 62);
            this.abfahrtLabel.Name = "abfahrtLabel";
            this.abfahrtLabel.Size = new System.Drawing.Size(66, 20);
            this.abfahrtLabel.TabIndex = 1;
            this.abfahrtLabel.Text = "Abfahrt:";
            // 
            // ankunftLabel
            // 
            this.ankunftLabel.AutoSize = true;
            this.ankunftLabel.Location = new System.Drawing.Point(220, 62);
            this.ankunftLabel.Name = "ankunftLabel";
            this.ankunftLabel.Size = new System.Drawing.Size(69, 20);
            this.ankunftLabel.TabIndex = 2;
            this.ankunftLabel.Text = "Ankunft:";
            // 
            // dauerLabel
            // 
            this.dauerLabel.AutoSize = true;
            this.dauerLabel.Location = new System.Drawing.Point(384, 62);
            this.dauerLabel.Name = "dauerLabel";
            this.dauerLabel.Size = new System.Drawing.Size(57, 20);
            this.dauerLabel.TabIndex = 3;
            this.dauerLabel.Text = "Dauer:";
            // 
            // abfahrtTextBox
            // 
            this.abfahrtTextBox.Location = new System.Drawing.Point(27, 85);
            this.abfahrtTextBox.Name = "abfahrtTextBox";
            this.abfahrtTextBox.Size = new System.Drawing.Size(100, 26);
            this.abfahrtTextBox.TabIndex = 4;
            // 
            // ankunftTextBox
            // 
            this.ankunftTextBox.Location = new System.Drawing.Point(202, 85);
            this.ankunftTextBox.Name = "ankunftTextBox";
            this.ankunftTextBox.Size = new System.Drawing.Size(100, 26);
            this.ankunftTextBox.TabIndex = 5;
            // 
            // dauerTextBox
            // 
            this.dauerTextBox.Location = new System.Drawing.Point(366, 85);
            this.dauerTextBox.Name = "dauerTextBox";
            this.dauerTextBox.Size = new System.Drawing.Size(100, 26);
            this.dauerTextBox.TabIndex = 6;
            // 
            // verbindungListBox
            // 
            this.verbindungListBox.FormattingEnabled = true;
            this.verbindungListBox.ItemHeight = 20;
            this.verbindungListBox.Location = new System.Drawing.Point(169, 148);
            this.verbindungListBox.Name = "verbindungListBox";
            this.verbindungListBox.Size = new System.Drawing.Size(241, 84);
            this.verbindungListBox.TabIndex = 7;
            this.verbindungListBox.SelectedIndexChanged += new System.EventHandler(this.verbindungListBox_SelectedIndexChanged);
            // 
            // verbindungsplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 264);
            this.Controls.Add(this.verbindungListBox);
            this.Controls.Add(this.dauerTextBox);
            this.Controls.Add(this.ankunftTextBox);
            this.Controls.Add(this.abfahrtTextBox);
            this.Controls.Add(this.dauerLabel);
            this.Controls.Add(this.ankunftLabel);
            this.Controls.Add(this.abfahrtLabel);
            this.Controls.Add(this.VerbindungenLabel);
            this.Name = "verbindungsplan";
            this.Text = "verbindungsplan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VerbindungenLabel;
        private System.Windows.Forms.Label abfahrtLabel;
        private System.Windows.Forms.Label ankunftLabel;
        private System.Windows.Forms.Label dauerLabel;
        private System.Windows.Forms.TextBox abfahrtTextBox;
        private System.Windows.Forms.TextBox ankunftTextBox;
        private System.Windows.Forms.TextBox dauerTextBox;
        private System.Windows.Forms.ListBox verbindungListBox;
    }
}