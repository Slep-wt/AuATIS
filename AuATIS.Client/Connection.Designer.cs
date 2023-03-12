namespace AuATIS.Client
{
    partial class Connection
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
            l_RealName = new Label();
            l_Password = new Label();
            l_CID = new Label();
            l_Rating = new Label();
            l_Server = new Label();
            l_Connect = new Label();
            t_RealName = new TextBox();
            t_VatsimID = new TextBox();
            t_Password = new TextBox();
            c_Ratings = new ComboBox();
            c_Servers = new ComboBox();
            SuspendLayout();
            // 
            // l_RealName
            // 
            l_RealName.AutoSize = true;
            l_RealName.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_RealName.ForeColor = Color.FromArgb(96, 0, 0);
            l_RealName.Location = new Point(31, 8);
            l_RealName.Name = "l_RealName";
            l_RealName.Size = new Size(70, 14);
            l_RealName.TabIndex = 0;
            l_RealName.Text = "Real Name";
            // 
            // l_Password
            // 
            l_Password.AutoSize = true;
            l_Password.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Password.ForeColor = Color.FromArgb(96, 0, 0);
            l_Password.Location = new Point(38, 72);
            l_Password.Name = "l_Password";
            l_Password.Size = new Size(63, 14);
            l_Password.TabIndex = 1;
            l_Password.Text = "Password";
            // 
            // l_CID
            // 
            l_CID.AutoSize = true;
            l_CID.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_CID.ForeColor = Color.FromArgb(96, 0, 0);
            l_CID.Location = new Point(31, 39);
            l_CID.Name = "l_CID";
            l_CID.Size = new Size(70, 14);
            l_CID.TabIndex = 2;
            l_CID.Text = "VATSIM ID";
            // 
            // l_Rating
            // 
            l_Rating.AutoSize = true;
            l_Rating.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Rating.ForeColor = Color.FromArgb(96, 0, 0);
            l_Rating.Location = new Point(260, 8);
            l_Rating.Name = "l_Rating";
            l_Rating.Size = new Size(49, 14);
            l_Rating.TabIndex = 3;
            l_Rating.Text = "Rating";
            // 
            // l_Server
            // 
            l_Server.AutoSize = true;
            l_Server.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            l_Server.ForeColor = Color.FromArgb(96, 0, 0);
            l_Server.Location = new Point(260, 39);
            l_Server.Name = "l_Server";
            l_Server.Size = new Size(49, 14);
            l_Server.TabIndex = 4;
            l_Server.Text = "Server";
            // 
            // l_Connect
            // 
            l_Connect.BackColor = Color.FromArgb(160, 170, 170);
            l_Connect.BorderStyle = BorderStyle.Fixed3D;
            l_Connect.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            l_Connect.ForeColor = Color.FromArgb(0, 0, 96);
            l_Connect.Location = new Point(353, 72);
            l_Connect.Margin = new Padding(0);
            l_Connect.Name = "l_Connect";
            l_Connect.Size = new Size(83, 26);
            l_Connect.TabIndex = 5;
            l_Connect.Text = "Connect";
            l_Connect.TextAlign = ContentAlignment.MiddleCenter;
            l_Connect.Click += l_Connect_Click;
            // 
            // t_RealName
            // 
            t_RealName.Location = new Point(107, 4);
            t_RealName.Name = "t_RealName";
            t_RealName.Size = new Size(124, 23);
            t_RealName.TabIndex = 6;
            // 
            // t_VatsimID
            // 
            t_VatsimID.Location = new Point(107, 35);
            t_VatsimID.Name = "t_VatsimID";
            t_VatsimID.Size = new Size(124, 23);
            t_VatsimID.TabIndex = 7;
            // 
            // t_Password
            // 
            t_Password.Location = new Point(107, 68);
            t_Password.Name = "t_Password";
            t_Password.PasswordChar = '*';
            t_Password.Size = new Size(124, 23);
            t_Password.TabIndex = 8;
            // 
            // c_Ratings
            // 
            c_Ratings.FormattingEnabled = true;
            c_Ratings.Location = new Point(315, 4);
            c_Ratings.Name = "c_Ratings";
            c_Ratings.Size = new Size(121, 23);
            c_Ratings.TabIndex = 11;
            // 
            // c_Servers
            // 
            c_Servers.FormattingEnabled = true;
            c_Servers.Location = new Point(315, 33);
            c_Servers.Name = "c_Servers";
            c_Servers.Size = new Size(121, 23);
            c_Servers.TabIndex = 12;
            // 
            // Connection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(160, 170, 170);
            ClientSize = new Size(448, 108);
            Controls.Add(c_Servers);
            Controls.Add(c_Ratings);
            Controls.Add(t_Password);
            Controls.Add(t_VatsimID);
            Controls.Add(t_RealName);
            Controls.Add(l_Connect);
            Controls.Add(l_Server);
            Controls.Add(l_Rating);
            Controls.Add(l_CID);
            Controls.Add(l_Password);
            Controls.Add(l_RealName);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Connection";
            Text = "Connection";
            FormClosing += Connection_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label l_RealName;
        private Label l_Password;
        private Label l_CID;
        private Label l_Rating;
        private Label l_Server;
        public Label l_Connect;
        private TextBox t_RealName;
        private TextBox t_VatsimID;
        private TextBox t_Password;
        private ComboBox c_Ratings;
        private ComboBox c_Servers;
    }
}