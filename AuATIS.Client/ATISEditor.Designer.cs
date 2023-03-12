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
            c_ATISLetter = new ComboBox();
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
            c_TimeCheck = new ComboBox();
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
            i_AirportICAO.BorderStyle = BorderStyle.FixedSingle;
            i_AirportICAO.CharacterCasing = CharacterCasing.Upper;
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
            i_ATISFreq.BorderStyle = BorderStyle.FixedSingle;
            i_ATISFreq.CharacterCasing = CharacterCasing.Upper;
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
            // c_ATISLetter
            // 
            c_ATISLetter.FormattingEnabled = true;
            c_ATISLetter.Location = new Point(115, 182);
            c_ATISLetter.Name = "c_ATISLetter";
            c_ATISLetter.Size = new Size(35, 22);
            c_ATISLetter.TabIndex = 4;
            // 
            // l_ATIS_AZ
            // 
            l_ATIS_AZ.AutoSize = true;
            l_ATIS_AZ.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_ATIS_AZ.Location = new Point(74, 185);
            l_ATIS_AZ.Name = "l_ATIS_AZ";
            l_ATIS_AZ.Size = new Size(35, 14);
            l_ATIS_AZ.TabIndex = 5;
            l_ATIS_AZ.Text = "ATIS";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(160, 170, 170);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(115, 209);
            textBox1.MaxLength = 500;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(308, 22);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(160, 170, 170);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(115, 236);
            textBox2.MaxLength = 500;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(308, 22);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(160, 170, 170);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(115, 263);
            textBox3.MaxLength = 500;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(308, 22);
            textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(160, 170, 170);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(115, 290);
            textBox4.MaxLength = 500;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(308, 22);
            textBox4.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(160, 170, 170);
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(115, 317);
            textBox5.MaxLength = 500;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(308, 22);
            textBox5.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(160, 170, 170);
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Location = new Point(115, 344);
            textBox6.MaxLength = 500;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(308, 22);
            textBox6.TabIndex = 11;
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(160, 170, 170);
            textBox7.BorderStyle = BorderStyle.FixedSingle;
            textBox7.Location = new Point(115, 371);
            textBox7.MaxLength = 500;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(308, 22);
            textBox7.TabIndex = 12;
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(160, 170, 170);
            textBox8.BorderStyle = BorderStyle.FixedSingle;
            textBox8.Location = new Point(115, 507);
            textBox8.MaxLength = 4;
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(308, 22);
            textBox8.TabIndex = 13;
            textBox8.Text = "GROUND OR APPROACH";
            // 
            // textBox9
            // 
            textBox9.BackColor = Color.FromArgb(160, 170, 170);
            textBox9.BorderStyle = BorderStyle.FixedSingle;
            textBox9.Location = new Point(115, 480);
            textBox9.MaxLength = 500;
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(308, 22);
            textBox9.TabIndex = 14;
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(160, 170, 170);
            textBox10.BorderStyle = BorderStyle.FixedSingle;
            textBox10.Location = new Point(115, 452);
            textBox10.MaxLength = 500;
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(308, 22);
            textBox10.TabIndex = 15;
            // 
            // textBox11
            // 
            textBox11.BackColor = Color.FromArgb(160, 170, 170);
            textBox11.BorderStyle = BorderStyle.FixedSingle;
            textBox11.Location = new Point(115, 425);
            textBox11.MaxLength = 500;
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(308, 22);
            textBox11.TabIndex = 16;
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.FromArgb(160, 170, 170);
            textBox12.BorderStyle = BorderStyle.FixedSingle;
            textBox12.Location = new Point(115, 398);
            textBox12.MaxLength = 500;
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(308, 22);
            textBox12.TabIndex = 17;
            // 
            // l_TimeCheck
            // 
            l_TimeCheck.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_TimeCheck.AutoSize = true;
            l_TimeCheck.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_TimeCheck.Location = new Point(32, 538);
            l_TimeCheck.Name = "l_TimeCheck";
            l_TimeCheck.Size = new Size(77, 14);
            l_TimeCheck.TabIndex = 19;
            l_TimeCheck.Text = "TIME_CHECK";
            l_TimeCheck.TextAlign = ContentAlignment.MiddleRight;
            // 
            // c_TimeCheck
            // 
            c_TimeCheck.FormattingEnabled = true;
            c_TimeCheck.Location = new Point(115, 535);
            c_TimeCheck.Name = "c_TimeCheck";
            c_TimeCheck.Size = new Size(53, 22);
            c_TimeCheck.TabIndex = 18;
            // 
            // l_12
            // 
            l_12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_12.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_12.Location = new Point(23, 509);
            l_12.Name = "l_12";
            l_12.Size = new Size(86, 14);
            l_12.TabIndex = 20;
            l_12.Text = "OFCW_NOTIFY";
            l_12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_1
            // 
            l_1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_1.Location = new Point(74, 211);
            l_1.Name = "l_1";
            l_1.Size = new Size(35, 14);
            l_1.TabIndex = 21;
            l_1.Text = "APCH";
            l_1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_2
            // 
            l_2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_2.Location = new Point(81, 238);
            l_2.Name = "l_2";
            l_2.Size = new Size(28, 14);
            l_2.TabIndex = 22;
            l_2.Text = "RWY";
            l_2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_3
            // 
            l_3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_3.Location = new Point(42, 265);
            l_3.Name = "l_3";
            l_3.Size = new Size(67, 14);
            l_3.TabIndex = 23;
            l_3.Text = "SFC COND";
            l_3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_4
            // 
            l_4.Location = new Point(42, 292);
            l_4.Name = "l_4";
            l_4.Size = new Size(67, 14);
            l_4.TabIndex = 24;
            l_4.Text = "OPR INFO";
            l_4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_5
            // 
            l_5.Location = new Point(74, 319);
            l_5.Name = "l_5";
            l_5.Size = new Size(35, 14);
            l_5.TabIndex = 25;
            l_5.Text = "WIND";
            l_5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_6
            // 
            l_6.Location = new Point(81, 346);
            l_6.Name = "l_6";
            l_6.Size = new Size(28, 14);
            l_6.TabIndex = 26;
            l_6.Text = "VIS";
            l_6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_7
            // 
            l_7.Location = new Point(81, 373);
            l_7.Name = "l_7";
            l_7.Size = new Size(28, 14);
            l_7.TabIndex = 27;
            l_7.Text = "WX";
            l_7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_8
            // 
            l_8.Location = new Point(81, 400);
            l_8.Name = "l_8";
            l_8.Size = new Size(28, 14);
            l_8.TabIndex = 28;
            l_8.Text = "CLD";
            l_8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_9
            // 
            l_9.Location = new Point(81, 427);
            l_9.Name = "l_9";
            l_9.Size = new Size(28, 14);
            l_9.TabIndex = 29;
            l_9.Text = "TMP";
            l_9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_10
            // 
            l_10.Location = new Point(81, 454);
            l_10.Name = "l_10";
            l_10.Size = new Size(28, 14);
            l_10.TabIndex = 30;
            l_10.Text = "QNH";
            l_10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_11
            // 
            l_11.Location = new Point(62, 482);
            l_11.Name = "l_11";
            l_11.Size = new Size(47, 14);
            l_11.TabIndex = 31;
            l_11.Text = "SIGWX";
            l_11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // l_METAR
            // 
            l_METAR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            l_METAR.Font = new Font("Consolas", 10F, FontStyle.Bold, GraphicsUnit.Point);
            l_METAR.ForeColor = Color.FromArgb(96, 0, 0);
            l_METAR.Location = new Point(78, 122);
            l_METAR.Name = "l_METAR";
            l_METAR.Size = new Size(322, 55);
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
            l_GetMETAR.Location = new Point(78, 61);
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
            l_Listen.Location = new Point(195, 61);
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
            l_Broadcast.Location = new Point(321, 61);
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
            label2.Location = new Point(195, 97);
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
            Controls.Add(c_TimeCheck);
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
            Controls.Add(c_ATISLetter);
            Controls.Add(label1);
            Controls.Add(l_ATISFreq);
            Controls.Add(i_ATISFreq);
            Controls.Add(i_AirportICAO);
            Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
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
        private ComboBox c_ATISLetter;
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
        private ComboBox c_TimeCheck;
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