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
            this.dauerListBox = new System.Windows.Forms.ListBox();
            this.zeitspannenListBox = new System.Windows.Forms.ListBox();
            this.zeitspannenLabel = new System.Windows.Forms.Label();
            this.dauerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nummerListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // VerbindungenLabel
            // 
            this.VerbindungenLabel.AutoSize = true;
            this.VerbindungenLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.VerbindungenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VerbindungenLabel.Location = new System.Drawing.Point(103, 9);
            this.VerbindungenLabel.Name = "VerbindungenLabel";
            this.VerbindungenLabel.Size = new System.Drawing.Size(229, 37);
            this.VerbindungenLabel.TabIndex = 0;
            this.VerbindungenLabel.Text = "Verbindungen";
            // 
            // dauerListBox
            // 
            this.dauerListBox.FormattingEnabled = true;
            this.dauerListBox.ItemHeight = 20;
            this.dauerListBox.Location = new System.Drawing.Point(394, 88);
            this.dauerListBox.Name = "dauerListBox";
            this.dauerListBox.Size = new System.Drawing.Size(88, 84);
            this.dauerListBox.TabIndex = 7;
            // 
            // zeitspannenListBox
            // 
            this.zeitspannenListBox.FormattingEnabled = true;
            this.zeitspannenListBox.ItemHeight = 20;
            this.zeitspannenListBox.Location = new System.Drawing.Point(12, 88);
            this.zeitspannenListBox.Name = "zeitspannenListBox";
            this.zeitspannenListBox.Size = new System.Drawing.Size(157, 84);
            this.zeitspannenListBox.TabIndex = 8;
            // 
            // zeitspannenLabel
            // 
            this.zeitspannenLabel.AutoSize = true;
            this.zeitspannenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeitspannenLabel.Location = new System.Drawing.Point(12, 59);
            this.zeitspannenLabel.Name = "zeitspannenLabel";
            this.zeitspannenLabel.Size = new System.Drawing.Size(136, 26);
            this.zeitspannenLabel.TabIndex = 9;
            this.zeitspannenLabel.Text = "Zeitspanne:";
            // 
            // dauerLabel
            // 
            this.dauerLabel.AutoSize = true;
            this.dauerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dauerLabel.Location = new System.Drawing.Point(389, 59);
            this.dauerLabel.Name = "dauerLabel";
            this.dauerLabel.Size = new System.Drawing.Size(83, 26);
            this.dauerLabel.TabIndex = 10;
            this.dauerLabel.Text = "Dauer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Bus/Zug Nr:";
            // 
            // nummerListBox
            // 
            this.nummerListBox.FormattingEnabled = true;
            this.nummerListBox.ItemHeight = 20;
            this.nummerListBox.Location = new System.Drawing.Point(209, 88);
            this.nummerListBox.Name = "nummerListBox";
            this.nummerListBox.Size = new System.Drawing.Size(135, 84);
            this.nummerListBox.TabIndex = 12;
            // 
            // verbindungsplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 179);
            this.Controls.Add(this.nummerListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dauerLabel);
            this.Controls.Add(this.zeitspannenLabel);
            this.Controls.Add(this.zeitspannenListBox);
            this.Controls.Add(this.dauerListBox);
            this.Controls.Add(this.VerbindungenLabel);
            this.Name = "verbindungsplan";
            this.Text = "verbindungsplan";
            this.Load += new System.EventHandler(this.verbindungsplan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VerbindungenLabel;
        private System.Windows.Forms.ListBox dauerListBox;
        private System.Windows.Forms.ListBox zeitspannenListBox;
        private System.Windows.Forms.Label zeitspannenLabel;
        private System.Windows.Forms.Label dauerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox nummerListBox;
    }
}