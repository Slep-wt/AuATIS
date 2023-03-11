namespace AuATIS.Client
{
    partial class ATISEditor
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
            i_AirportICAO = new TextBox();
            i_ATISFreq = new TextBox();
            l_ATISFreq = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // i_AirportICAO
            // 
            i_AirportICAO.Location = new Point(78, 26);
            i_AirportICAO.MaxLength = 4;
            i_AirportICAO.Name = "i_AirportICAO";
            i_AirportICAO.Size = new Size(100, 23);
            i_AirportICAO.TabIndex = 0;
            // 
            // i_ATISFreq
            // 
            i_ATISFreq.Location = new Point(265, 26);
            i_ATISFreq.Name = "i_ATISFreq";
            i_ATISFreq.ReadOnly = true;
            i_ATISFreq.Size = new Size(100, 23);
            i_ATISFreq.TabIndex = 1;
            // 
            // l_ATISFreq
            // 
            l_ATISFreq.AutoSize = true;
            l_ATISFreq.Location = new Point(226, 29);
            l_ATISFreq.Name = "l_ATISFreq";
            l_ATISFreq.Size = new Size(33, 15);
            l_ATISFreq.TabIndex = 2;
            l_ATISFreq.Text = "Freq:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 3;
            label1.Text = "Airport:";
            // 
            // ATISEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 491);
            Controls.Add(label1);
            Controls.Add(l_ATISFreq);
            Controls.Add(i_ATISFreq);
            Controls.Add(i_AirportICAO);
            Name = "ATISEditor";
            Text = "ATIS Editor";
            FormClosing += ATISEditor_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox i_AirportICAO;
        private TextBox i_ATISFreq;
        private Label l_ATISFreq;
        private Label label1;
    }
}