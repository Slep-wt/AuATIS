namespace AuATIS.Client
{
    public partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            t_TimeUTC = new Label();
            TopBackground = new Label();
            l_ProfileCurrent = new Label();
            l_Settings = new Label();
            l_d_Connection = new Label();
            l_d_ChangeProfile = new Label();
            l_Editor = new Label();
            l_Atis2 = new Label();
            l_Atis1 = new Label();
            l_Atis4 = new Label();
            l_Atis3 = new Label();
            SuspendLayout();
            // 
            // t_TimeUTC
            // 
            t_TimeUTC.BackColor = Color.FromArgb(160, 170, 170);
            t_TimeUTC.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            t_TimeUTC.ForeColor = Color.FromArgb(0, 0, 96);
            t_TimeUTC.Location = new Point(6, 0);
            t_TimeUTC.Name = "t_TimeUTC";
            t_TimeUTC.Size = new Size(64, 26);
            t_TimeUTC.TabIndex = 0;
            t_TimeUTC.Text = "00:00:00";
            t_TimeUTC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TopBackground
            // 
            TopBackground.BackColor = Color.FromArgb(160, 170, 170);
            TopBackground.Location = new Point(-1, 0);
            TopBackground.Name = "TopBackground";
            TopBackground.Size = new Size(452, 26);
            TopBackground.TabIndex = 3;
            // 
            // l_ProfileCurrent
            // 
            l_ProfileCurrent.BackColor = Color.FromArgb(160, 170, 170);
            l_ProfileCurrent.Font = new Font("Consolas", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            l_ProfileCurrent.ForeColor = Color.FromArgb(96, 0, 0);
            l_ProfileCurrent.Location = new Point(73, 0);
            l_ProfileCurrent.Margin = new Padding(0);
            l_ProfileCurrent.Name = "l_ProfileCurrent";
            l_ProfileCurrent.Size = new Size(80, 26);
            l_ProfileCurrent.TabIndex = 0;
            l_ProfileCurrent.Text = "Profile";
            l_ProfileCurrent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // l_Settings
            // 
            l_Settings.BackColor = Color.FromArgb(160, 170, 170);
            l_Settings.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Settings.ForeColor = Color.FromArgb(0, 0, 96);
            l_Settings.Location = new Point(158, 0);
            l_Settings.Margin = new Padding(0);
            l_Settings.Name = "l_Settings";
            l_Settings.Size = new Size(67, 26);
            l_Settings.TabIndex = 1;
            l_Settings.Text = "Settings";
            l_Settings.TextAlign = ContentAlignment.MiddleCenter;
            l_Settings.MouseClick += l_Settings_Click;
            l_Settings.MouseDoubleClick += l_Settings_Click;
            l_Settings.MouseEnter += Taskbar_MouseEnter;
            l_Settings.MouseLeave += Taskbar_MouseLeave;
            // 
            // l_d_Connection
            // 
            l_d_Connection.BackColor = Color.FromArgb(160, 170, 170);
            l_d_Connection.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_d_Connection.ForeColor = Color.FromArgb(0, 0, 96);
            l_d_Connection.Location = new Point(158, 26);
            l_d_Connection.Margin = new Padding(0);
            l_d_Connection.Name = "l_d_Connection";
            l_d_Connection.Padding = new Padding(6, 0, 0, 0);
            l_d_Connection.Size = new Size(120, 22);
            l_d_Connection.TabIndex = 2;
            l_d_Connection.Text = "Connection";
            l_d_Connection.TextAlign = ContentAlignment.MiddleLeft;
            l_d_Connection.Visible = false;
            l_d_Connection.Click += l_d_Connection_Click;
            l_d_Connection.MouseEnter += Taskbar_MouseEnter;
            l_d_Connection.MouseLeave += Taskbar_MouseLeave;
            // 
            // l_d_ChangeProfile
            // 
            l_d_ChangeProfile.BackColor = Color.FromArgb(160, 170, 170);
            l_d_ChangeProfile.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_d_ChangeProfile.ForeColor = Color.FromArgb(0, 0, 96);
            l_d_ChangeProfile.Location = new Point(158, 48);
            l_d_ChangeProfile.Margin = new Padding(0);
            l_d_ChangeProfile.Name = "l_d_ChangeProfile";
            l_d_ChangeProfile.Padding = new Padding(6, 0, 0, 0);
            l_d_ChangeProfile.Size = new Size(120, 22);
            l_d_ChangeProfile.TabIndex = 3;
            l_d_ChangeProfile.Text = "Change Profile";
            l_d_ChangeProfile.TextAlign = ContentAlignment.MiddleLeft;
            l_d_ChangeProfile.Visible = false;
            l_d_ChangeProfile.Click += l_d_ChangeProfile_Click;
            l_d_ChangeProfile.MouseEnter += Taskbar_MouseEnter;
            l_d_ChangeProfile.MouseLeave += Taskbar_MouseLeave;
            // 
            // l_Editor
            // 
            l_Editor.BackColor = Color.FromArgb(160, 170, 170);
            l_Editor.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Editor.ForeColor = Color.FromArgb(0, 0, 96);
            l_Editor.Location = new Point(236, 0);
            l_Editor.Margin = new Padding(0);
            l_Editor.Name = "l_Editor";
            l_Editor.Size = new Size(67, 26);
            l_Editor.TabIndex = 4;
            l_Editor.Text = "Editor";
            l_Editor.TextAlign = ContentAlignment.MiddleCenter;
            l_Editor.MouseClick += l_Editor_MouseClick;
            l_Editor.MouseDoubleClick += l_Editor_MouseClick;
            l_Editor.MouseEnter += Taskbar_MouseEnter;
            l_Editor.MouseLeave += Taskbar_MouseLeave;
            // 
            // l_Atis2
            // 
            l_Atis2.BackColor = Color.FromArgb(160, 170, 170);
            l_Atis2.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Atis2.ForeColor = Color.FromArgb(0, 0, 96);
            l_Atis2.Location = new Point(236, 48);
            l_Atis2.Margin = new Padding(0);
            l_Atis2.Name = "l_Atis2";
            l_Atis2.Padding = new Padding(6, 0, 0, 0);
            l_Atis2.Size = new Size(89, 22);
            l_Atis2.TabIndex = 6;
            l_Atis2.Text = "Atis 2";
            l_Atis2.TextAlign = ContentAlignment.MiddleLeft;
            l_Atis2.Visible = false;
            // 
            // l_Atis1
            // 
            l_Atis1.BackColor = Color.FromArgb(160, 170, 170);
            l_Atis1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Atis1.ForeColor = Color.FromArgb(0, 0, 96);
            l_Atis1.Location = new Point(236, 26);
            l_Atis1.Margin = new Padding(0);
            l_Atis1.Name = "l_Atis1";
            l_Atis1.Padding = new Padding(6, 0, 0, 0);
            l_Atis1.Size = new Size(89, 22);
            l_Atis1.TabIndex = 5;
            l_Atis1.Text = "Atis 1";
            l_Atis1.TextAlign = ContentAlignment.MiddleLeft;
            l_Atis1.Visible = false;
            // 
            // l_Atis4
            // 
            l_Atis4.BackColor = Color.FromArgb(160, 170, 170);
            l_Atis4.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Atis4.ForeColor = Color.FromArgb(0, 0, 96);
            l_Atis4.Location = new Point(236, 92);
            l_Atis4.Margin = new Padding(0);
            l_Atis4.Name = "l_Atis4";
            l_Atis4.Padding = new Padding(6, 0, 0, 0);
            l_Atis4.Size = new Size(89, 22);
            l_Atis4.TabIndex = 8;
            l_Atis4.Text = "Atis 4";
            l_Atis4.TextAlign = ContentAlignment.MiddleLeft;
            l_Atis4.Visible = false;
            // 
            // l_Atis3
            // 
            l_Atis3.BackColor = Color.FromArgb(160, 170, 170);
            l_Atis3.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Atis3.ForeColor = Color.FromArgb(0, 0, 96);
            l_Atis3.Location = new Point(236, 70);
            l_Atis3.Margin = new Padding(0);
            l_Atis3.Name = "l_Atis3";
            l_Atis3.Padding = new Padding(6, 0, 0, 0);
            l_Atis3.Size = new Size(89, 22);
            l_Atis3.TabIndex = 7;
            l_Atis3.Text = "Atis 3";
            l_Atis3.TextAlign = ContentAlignment.MiddleLeft;
            l_Atis3.Visible = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(127, 127, 127);
            ClientSize = new Size(446, 420);
            Controls.Add(l_Atis4);
            Controls.Add(l_Atis3);
            Controls.Add(l_Atis2);
            Controls.Add(l_Atis1);
            Controls.Add(l_Editor);
            Controls.Add(l_d_ChangeProfile);
            Controls.Add(l_d_Connection);
            Controls.Add(l_Settings);
            Controls.Add(l_ProfileCurrent);
            Controls.Add(t_TimeUTC);
            Controls.Add(TopBackground);
            Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "AuATIS";
            TransparencyKey = Color.Transparent;
            FormClosing += MainForm_FormClosing;
            Click += MainForm_Click;
            ResumeLayout(false);
        }

        #endregion

        public Label t_TimeUTC;
        private Label TopBackground;
        public Label l_ProfileCurrent;
        public Label l_Settings;
        public Label l_d_Connection;
        public Label l_d_ChangeProfile;
        public Label l_Editor;
        public Label l_Atis2;
        public Label l_Atis1;
        public Label l_Atis4;
        public Label l_Atis3;
    }
}