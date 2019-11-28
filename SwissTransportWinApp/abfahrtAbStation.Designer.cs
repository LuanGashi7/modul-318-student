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
            this.abfahrtLabel = new System.Windows.Forms.Label();
            this.richtungsLabel = new System.Windows.Forms.Label();
            this.abfahrtTextBoxStation = new System.Windows.Forms.TextBox();
            this.richtungTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // verbindungLabel
            // 
            this.verbindungLabel.AutoSize = true;
            this.verbindungLabel.Location = new System.Drawing.Point(120, 9);
            this.verbindungLabel.Name = "verbindungLabel";
            this.verbindungLabel.Size = new System.Drawing.Size(109, 20);
            this.verbindungLabel.TabIndex = 0;
            this.verbindungLabel.Text = "Verbindungen";
            // 
            // abfahrtLabel
            // 
            this.abfahrtLabel.AutoSize = true;
            this.abfahrtLabel.Location = new System.Drawing.Point(26, 48);
            this.abfahrtLabel.Name = "abfahrtLabel";
            this.abfahrtLabel.Size = new System.Drawing.Size(66, 20);
            this.abfahrtLabel.TabIndex = 1;
            this.abfahrtLabel.Text = "Abfahrt:";
            // 
            // richtungsLabel
            // 
            this.richtungsLabel.AutoSize = true;
            this.richtungsLabel.Location = new System.Drawing.Point(205, 48);
            this.richtungsLabel.Name = "richtungsLabel";
            this.richtungsLabel.Size = new System.Drawing.Size(73, 20);
            this.richtungsLabel.TabIndex = 2;
            this.richtungsLabel.Text = "Richtung";
            // 
            // abfahrtTextBoxStation
            // 
            this.abfahrtTextBoxStation.Location = new System.Drawing.Point(30, 71);
            this.abfahrtTextBoxStation.Name = "abfahrtTextBoxStation";
            this.abfahrtTextBoxStation.Size = new System.Drawing.Size(100, 26);
            this.abfahrtTextBoxStation.TabIndex = 3;
            // 
            // richtungTextBox
            // 
            this.richtungTextBox.Location = new System.Drawing.Point(209, 71);
            this.richtungTextBox.Name = "richtungTextBox";
            this.richtungTextBox.Size = new System.Drawing.Size(184, 26);
            this.richtungTextBox.TabIndex = 4;
            // 
            // abfahrtAbStation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 124);
            this.Controls.Add(this.richtungTextBox);
            this.Controls.Add(this.abfahrtTextBoxStation);
            this.Controls.Add(this.richtungsLabel);
            this.Controls.Add(this.abfahrtLabel);
            this.Controls.Add(this.verbindungLabel);
            this.Name = "abfahrtAbStation";
            this.Text = "abfahrtAbStation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label verbindungLabel;
        private System.Windows.Forms.Label abfahrtLabel;
        private System.Windows.Forms.Label richtungsLabel;
        private System.Windows.Forms.TextBox abfahrtTextBoxStation;
        private System.Windows.Forms.TextBox richtungTextBox;
    }
}