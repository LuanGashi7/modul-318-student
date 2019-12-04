namespace SwissTransportWinApp
{
    partial class abfahrtAbStation
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
            this.verbindungLabel = new System.Windows.Forms.Label();
            this.stationTimeBoardListBox = new System.Windows.Forms.ListBox();
            this.richtungLabel = new System.Windows.Forms.Label();
            this.zeitLabel = new System.Windows.Forms.Label();
            this.richtungListBox = new System.Windows.Forms.ListBox();
            this.nummerLabel = new System.Windows.Forms.Label();
            this.nummerListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // verbindungLabel
            // 
            this.verbindungLabel.AutoSize = true;
            this.verbindungLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.verbindungLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verbindungLabel.Location = new System.Drawing.Point(212, 9);
            this.verbindungLabel.Name = "verbindungLabel";
            this.verbindungLabel.Size = new System.Drawing.Size(229, 37);
            this.verbindungLabel.TabIndex = 0;
            this.verbindungLabel.Text = "Verbindungen";
            // 
            // stationTimeBoardListBox
            // 
            this.stationTimeBoardListBox.FormattingEnabled = true;
            this.stationTimeBoardListBox.ItemHeight = 20;
            this.stationTimeBoardListBox.Location = new System.Drawing.Point(5, 86);
            this.stationTimeBoardListBox.Name = "stationTimeBoardListBox";
            this.stationTimeBoardListBox.Size = new System.Drawing.Size(110, 104);
            this.stationTimeBoardListBox.TabIndex = 1;
            // 
            // richtungLabel
            // 
            this.richtungLabel.AutoSize = true;
            this.richtungLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtungLabel.Location = new System.Drawing.Point(318, 57);
            this.richtungLabel.Name = "richtungLabel";
            this.richtungLabel.Size = new System.Drawing.Size(113, 26);
            this.richtungLabel.TabIndex = 2;
            this.richtungLabel.Text = "Richtung:";
            // 
            // zeitLabel
            // 
            this.zeitLabel.AutoSize = true;
            this.zeitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeitLabel.Location = new System.Drawing.Point(0, 55);
            this.zeitLabel.Name = "zeitLabel";
            this.zeitLabel.Size = new System.Drawing.Size(59, 26);
            this.zeitLabel.TabIndex = 3;
            this.zeitLabel.Text = "Zeit:";
            // 
            // richtungListBox
            // 
            this.richtungListBox.FormattingEnabled = true;
            this.richtungListBox.ItemHeight = 20;
            this.richtungListBox.Location = new System.Drawing.Point(323, 86);
            this.richtungListBox.Name = "richtungListBox";
            this.richtungListBox.Size = new System.Drawing.Size(257, 104);
            this.richtungListBox.TabIndex = 4;
            // 
            // nummerLabel
            // 
            this.nummerLabel.AutoSize = true;
            this.nummerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nummerLabel.Location = new System.Drawing.Point(145, 55);
            this.nummerLabel.Name = "nummerLabel";
            this.nummerLabel.Size = new System.Drawing.Size(139, 26);
            this.nummerLabel.TabIndex = 5;
            this.nummerLabel.Text = "Bus/Zug Nr:";
            // 
            // nummerListBox
            // 
            this.nummerListBox.FormattingEnabled = true;
            this.nummerListBox.ItemHeight = 20;
            this.nummerListBox.Location = new System.Drawing.Point(150, 86);
            this.nummerListBox.Name = "nummerListBox";
            this.nummerListBox.Size = new System.Drawing.Size(134, 104);
            this.nummerListBox.TabIndex = 6;
            // 
            // abfahrtAbStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 199);
            this.Controls.Add(this.nummerListBox);
            this.Controls.Add(this.nummerLabel);
            this.Controls.Add(this.richtungListBox);
            this.Controls.Add(this.zeitLabel);
            this.Controls.Add(this.richtungLabel);
            this.Controls.Add(this.stationTimeBoardListBox);
            this.Controls.Add(this.verbindungLabel);
            this.Name = "abfahrtAbStation";
            this.Text = "abfahrtAbStation";
            this.Load += new System.EventHandler(this.abfahrtAbStation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label verbindungLabel;
        private System.Windows.Forms.ListBox stationTimeBoardListBox;
        private System.Windows.Forms.Label richtungLabel;
        private System.Windows.Forms.Label zeitLabel;
        private System.Windows.Forms.ListBox richtungListBox;
        private System.Windows.Forms.Label nummerLabel;
        private System.Windows.Forms.ListBox nummerListBox;
    }
}