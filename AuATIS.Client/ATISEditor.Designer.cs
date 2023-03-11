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
            comboBox1 = new ComboBox();
            l_ATIS_AZ = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            textBox12 = new TextBox();
            l_TimeCheck = new Label();
            comboBox2 = new ComboBox();
            l_12 = new Label();
            l_1 = new Label();
            l_2 = new Label();
            l_3 = new Label();
            l_4 = new Label();
            l_5 = new Label();
            l_6 = new Label();
            l_7 = new Label();
            l_8 = new Label();
            l_9 = new Label();
            l_10 = new Label();
            l_11 = new Label();
            l_METAR = new Label();
            l_GetMETAR = new Label();
            l_Listen = new Label();
            l_Broadcast = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // i_AirportICAO
            // 
            i_AirportICAO.BackColor = Color.FromArgb(160, 170, 170);
            i_AirportICAO.Location = new Point(78, 24);
            i_AirportICAO.MaxLength = 4;
            i_AirportICAO.Name = "i_AirportICAO";
            i_AirportICAO.Size = new Size(67, 22);
            i_AirportICAO.TabIndex = 0;
            i_AirportICAO.TextChanged += i_AirportICAO_TextChanged;
            // 
            // i_ATISFreq
            // 
            i_ATISFreq.BackColor = Color.FromArgb(160, 170, 170);
            i_ATISFreq.Location = new Point(214, 24);
            i_ATISFreq.Name = "i_ATISFreq";
            i_ATISFreq.ReadOnly = true;
            i_ATISFreq.Size = new Size(67, 22);
            i_ATISFreq.TabIndex = 1;
            // 
            // l_ATISFreq
            // 
            l_ATISFreq.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_ATISFreq.ForeColor = Color.FromArgb(96, 0, 0);
            l_ATISFreq.Location = new Point(166, 28);
            l_ATISFreq.Name = "l_ATISFreq";
            l_ATISFreq.Size = new Size(42, 14);
            l_ATISFreq.TabIndex = 2;
            l_ATISFreq.Text = "Freq:";
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(96, 0, 0);
            label1.Location = new Point(12, 28);
            label1.Name = "label1";
            label1.Size = new Size(64, 14);
            label1.TabIndex = 3;
            label1.Text = "Airport:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(92, 173);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(35, 22);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // l_ATIS_AZ
            // 
            l_ATIS_AZ.AutoSize = true;
            l_ATIS_AZ.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_ATIS_AZ.Location = new Point(51, 176);
            l_ATIS_AZ.Name = "l_ATIS_AZ";
            l_ATIS_AZ.Size = new Size(35, 14);
            l_ATIS_AZ.TabIndex = 5;
            l_ATIS_AZ.Text = "ATIS";
            l_ATIS_AZ.Click += l_ATIS_AZ_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(160, 170, 170);
            textBox1.Location = new Point(92, 200);
            textBox1.MaxLength = 4;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 22);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(160, 170, 170);
            textBox2.Location = new Point(92, 227);
            textBox2.MaxLength = 4;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 22);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(160, 170, 170);
            textBox3.Location = new Point(92, 254);
            textBox3.MaxLength = 4;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 22);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(160, 170, 170);
            textBox4.Location = new Point(92, 281);
            textBox4.MaxLength = 4;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(308, 22);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(160, 170, 170);
            textBox5.Location = new Point(92, 308);
            textBox5.MaxLength = 4;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(308, 22);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(160, 170, 170);
            textBox6.Location = new Point(92, 335);
            textBox6.MaxLength = 4;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(308, 22);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(160, 170, 170);
            textBox7.Location = new Point(92, 362);
            textBox7.MaxLength = 4;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(308, 22);
            textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(160, 170, 170);
            textBox8.Location = new Point(92, 498);
            textBox8.MaxLength = 4;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(308, 22);
            textBox8.TabIndex = 13;
            textBox8.Text = "GROUND OR APPROACH";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(160, 170, 170);
            textBox9.Location = new Point(92, 471);
            textBox9.MaxLength = 4;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(308, 22);
            textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(160, 170, 170);
            textBox10.Location = new Point(92, 443);
            textBox10.MaxLength = 4;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(308, 22);
            textBox10.TabIndex = 15;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(160, 170, 170);
            textBox11.Location = new Point(92, 416);
            textBox11.MaxLength = 4;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(308, 22);
            textBox11.TabIndex = 16;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.FromArgb(160, 170, 170);
            textBox12.Location = new Point(92, 389);
            textBox12.MaxLength = 4;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(308, 22);
            textBox12.TabIndex = 17;
            // 
            // l_TimeCheck
            // 
            l_TimeCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_TimeCheck.AutoSize = true;
            l_TimeCheck.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_TimeCheck.Location = new Point(9, 528);
            l_TimeCheck.Name = "l_TimeCheck";
            l_TimeCheck.Size = new Size(77, 14);
            l_TimeCheck.TabIndex = 19;
            l_TimeCheck.Text = "TIME_CHECK";
            l_TimeCheck.Click += l_TimeCheck_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(92, 526);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(53, 22);
            comboBox2.TabIndex = 18;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // l_12
            // 
            l_12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_12.AutoSize = true;
            l_12.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_12.Location = new Point(58, 501);
            l_12.Name = "l_12";
            l_12.Size = new Size(28, 14);
            l_12.TabIndex = 20;
            l_12.Text = "L12";
            // 
            // l_1
            // 
            l_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_1.AutoSize = true;
            l_1.Location = new Point(58, 200);
            l_1.Name = "l_1";
            l_1.Size = new Size(21, 14);
            l_1.TabIndex = 21;
            l_1.Text = "L1";
            // 
            // l_2
            // 
            l_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_2.AutoSize = true;
            l_2.Location = new Point(58, 230);
            l_2.Name = "l_2";
            l_2.Size = new Size(21, 14);
            l_2.TabIndex = 22;
            l_2.Text = "L2";
            // 
            // l_3
            // 
            l_3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_3.AutoSize = true;
            l_3.Location = new Point(58, 257);
            l_3.Name = "l_3";
            l_3.Size = new Size(21, 14);
            l_3.TabIndex = 23;
            l_3.Text = "L3";
            // 
            // l_4
            // 
            l_4.AutoSize = true;
            l_4.Location = new Point(58, 284);
            l_4.Name = "l_4";
            l_4.Size = new Size(21, 14);
            l_4.TabIndex = 24;
            l_4.Text = "L4";
            // 
            // l_5
            // 
            l_5.AutoSize = true;
            l_5.Location = new Point(58, 311);
            l_5.Name = "l_5";
            l_5.Size = new Size(21, 14);
            l_5.TabIndex = 25;
            l_5.Text = "L5";
            // 
            // l_6
            // 
            l_6.AutoSize = true;
            l_6.Location = new Point(58, 338);
            l_6.Name = "l_6";
            l_6.Size = new Size(21, 14);
            l_6.TabIndex = 26;
            l_6.Text = "L6";
            // 
            // l_7
            // 
            l_7.AutoSize = true;
            l_7.Location = new Point(58, 365);
            l_7.Name = "l_7";
            l_7.Size = new Size(21, 14);
            l_7.TabIndex = 27;
            l_7.Text = "L7";
            // 
            // l_8
            // 
            l_8.AutoSize = true;
            l_8.Location = new Point(58, 392);
            l_8.Name = "l_8";
            l_8.Size = new Size(21, 14);
            l_8.TabIndex = 28;
            l_8.Text = "L8";
            // 
            // l_9
            // 
            l_9.AutoSize = true;
            l_9.Location = new Point(58, 419);
            l_9.Name = "l_9";
            l_9.Size = new Size(21, 14);
            l_9.TabIndex = 29;
            l_9.Text = "L9";
            // 
            // l_10
            // 
            l_10.AutoSize = true;
            l_10.Location = new Point(58, 446);
            l_10.Name = "l_10";
            l_10.Size = new Size(28, 14);
            l_10.TabIndex = 30;
            l_10.Text = "L10";
            // 
            // l_11
            // 
            l_11.AutoSize = true;
            l_11.Location = new Point(58, 474);
            l_11.Name = "l_11";
            l_11.Size = new Size(28, 14);
            l_11.TabIndex = 31;
            l_11.Text = "L11";
            // 
            // l_METAR
            // 
            l_METAR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_METAR.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            l_METAR.ForeColor = Color.FromArgb(96, 0, 0);
            l_METAR.Location = new Point(78, 145);
            l_METAR.Name = "l_METAR";
            l_METAR.Size = new Size(322, 14);
            l_METAR.TabIndex = 35;
            l_METAR.Text = "No METAR";
            l_METAR.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_GetMETAR
            // 
            l_GetMETAR.BackColor = Color.FromArgb(160, 170, 170);
            l_GetMETAR.BorderStyle = BorderStyle.Fixed3D;
            l_GetMETAR.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_GetMETAR.ForeColor = Color.FromArgb(0, 0, 96);
            l_GetMETAR.Location = new Point(78, 75);
            l_GetMETAR.Margin = new Padding(0);
            l_GetMETAR.Name = "l_GetMETAR";
            l_GetMETAR.Size = new Size(82, 26);
            l_GetMETAR.TabIndex = 36;
            l_GetMETAR.Text = "Load METAR";
            l_GetMETAR.TextAlign = ContentAlignment.MiddleCenter;
            l_GetMETAR.Click += l_GetMETAR_Click;
            // 
            // l_Listen
            // 
            l_Listen.BackColor = Color.FromArgb(160, 170, 170);
            l_Listen.BorderStyle = BorderStyle.Fixed3D;
            l_Listen.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Listen.ForeColor = Color.FromArgb(0, 0, 96);
            l_Listen.Location = new Point(195, 75);
            l_Listen.Margin = new Padding(0);
            l_Listen.Name = "l_Listen";
            l_Listen.Size = new Size(86, 26);
            l_Listen.TabIndex = 37;
            l_Listen.Text = "Listen";
            l_Listen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_Broadcast
            // 
            l_Broadcast.BackColor = Color.FromArgb(160, 170, 170);
            l_Broadcast.BorderStyle = BorderStyle.Fixed3D;
            l_Broadcast.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Broadcast.ForeColor = Color.FromArgb(0, 0, 96);
            l_Broadcast.Location = new Point(321, 75);
            l_Broadcast.Margin = new Padding(0);
            l_Broadcast.Name = "l_Broadcast";
            l_Broadcast.Size = new Size(79, 26);
            l_Broadcast.TabIndex = 38;
            l_Broadcast.Text = "Broadcast";
            l_Broadcast.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(160, 170, 170);
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(0, 0, 96);
            label2.Location = new Point(195, 111);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(86, 21);
            label2.TabIndex = 39;
            label2.Text = "Wind Calc";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(160, 170, 170);
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(0, 0, 96);
            label3.Location = new Point(321, 22);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(79, 26);
            label3.TabIndex = 40;
            label3.Text = "Create";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ATISEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 170, 170);
            ClientSize = new Size(473, 573);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(l_GetMETAR);
            Controls.Add(l_Broadcast);
            Controls.Add(l_Listen);
            Controls.Add(l_METAR);
            Controls.Add(l_11);
            Controls.Add(l_10);
            Controls.Add(l_9);
            Controls.Add(l_8);
            Controls.Add(l_7);
            Controls.Add(l_6);
            Controls.Add(l_5);
            Controls.Add(l_4);
            Controls.Add(l_3);
            Controls.Add(l_2);
            Controls.Add(l_1);
            Controls.Add(l_12);
            Controls.Add(l_TimeCheck);
            Controls.Add(comboBox2);
            Controls.Add(textBox12);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(l_ATIS_AZ);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(l_ATISFreq);
            Controls.Add(i_ATISFreq);
            Controls.Add(i_AirportICAO);
            Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "ATISEditor";
            Text = "ATIS Editor";
            FormClosing += ATISEditor_FormClosing;
            Load += ATISEditor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox i_AirportICAO;
        private TextBox i_ATISFreq;
        private Label l_ATISFreq;
        private Label label1;
        private ComboBox comboBox1;
        private Label l_ATIS_AZ;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private Label l_TimeCheck;
        private ComboBox comboBox2;
        private Label l_12;
        private Label l_1;
        private Label l_2;
        private Label l_3;
        private Label l_4;
        private Label l_5;
        private Label l_6;
        private Label l_7;
        private Label l_8;
        private Label l_9;
        private Label l_10;
        private Label l_11;
        private Label l_METAR;
        public Label l_GetMETAR;
        public Label l_Listen;
        public Label l_Broadcast;
        public Label label2;
        public Label label3;
    }
}