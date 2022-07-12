namespace synthesis_assignment
{
    partial class DesktopApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tabPageTournament = new System.Windows.Forms.TabPage();
            this.btnCreateTournament = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.RichTextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.mCalendarEnd = new System.Windows.Forms.MonthCalendar();
            this.mCalendarStart = new System.Windows.Forms.MonthCalendar();
            this.cbTournamentType = new System.Windows.Forms.ComboBox();
            this.cbSportType = new System.Windows.Forms.ComboBox();
            this.lblTournamentType = new System.Windows.Forms.Label();
            this.lblSportType = new System.Windows.Forms.Label();
            this.lblMaxPlayers = new System.Windows.Forms.Label();
            this.lblMinPlayers = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblTournamentName = new System.Windows.Forms.Label();
            this.tbMinPlayers = new System.Windows.Forms.TextBox();
            this.tbMaxPlayers = new System.Windows.Forms.TextBox();
            this.tbLocation = new System.Windows.Forms.TextBox();
            this.tbTournamentName = new System.Windows.Forms.TextBox();
            this.tabPageEmployeemanagement = new System.Windows.Forms.TabPage();
            this.lblPasswordSU = new System.Windows.Forms.Label();
            this.lblUserNameSU = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblEmailSU = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.cbPositionSU = new System.Windows.Forms.ComboBox();
            this.lblPositionSU = new System.Windows.Forms.Label();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageTournament.SuspendLayout();
            this.tabPageEmployeemanagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLogin);
            this.tabControl1.Controls.Add(this.tabPageTournament);
            this.tabControl1.Controls.Add(this.tabPageEmployeemanagement);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1051, 578);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.lblPassword);
            this.tabPageLogin.Controls.Add(this.lblUserName);
            this.tabPageLogin.Controls.Add(this.btnLogin);
            this.tabPageLogin.Controls.Add(this.tbPassword);
            this.tabPageLogin.Controls.Add(this.tbUserName);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 29);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(1043, 545);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(262, 216);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(262, 133);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(81, 20);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "UserName:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(452, 296);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(437, 209);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(125, 27);
            this.tbPassword.TabIndex = 1;
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(437, 133);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(125, 27);
            this.tbUserName.TabIndex = 0;
            // 
            // tabPageTournament
            // 
            this.tabPageTournament.Controls.Add(this.btnCreateTournament);
            this.tabPageTournament.Controls.Add(this.tbDescription);
            this.tabPageTournament.Controls.Add(this.lblDescription);
            this.tabPageTournament.Controls.Add(this.lblEndDate);
            this.tabPageTournament.Controls.Add(this.lblStartDate);
            this.tabPageTournament.Controls.Add(this.mCalendarEnd);
            this.tabPageTournament.Controls.Add(this.mCalendarStart);
            this.tabPageTournament.Controls.Add(this.cbTournamentType);
            this.tabPageTournament.Controls.Add(this.cbSportType);
            this.tabPageTournament.Controls.Add(this.lblTournamentType);
            this.tabPageTournament.Controls.Add(this.lblSportType);
            this.tabPageTournament.Controls.Add(this.lblMaxPlayers);
            this.tabPageTournament.Controls.Add(this.lblMinPlayers);
            this.tabPageTournament.Controls.Add(this.lblLocation);
            this.tabPageTournament.Controls.Add(this.lblTournamentName);
            this.tabPageTournament.Controls.Add(this.tbMinPlayers);
            this.tabPageTournament.Controls.Add(this.tbMaxPlayers);
            this.tabPageTournament.Controls.Add(this.tbLocation);
            this.tabPageTournament.Controls.Add(this.tbTournamentName);
            this.tabPageTournament.Location = new System.Drawing.Point(4, 29);
            this.tabPageTournament.Name = "tabPageTournament";
            this.tabPageTournament.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTournament.Size = new System.Drawing.Size(1043, 545);
            this.tabPageTournament.TabIndex = 1;
            this.tabPageTournament.Text = "Tournament";
            this.tabPageTournament.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(643, 474);
            this.btnCreateTournament.Name = "btnCreateTournament";
            this.btnCreateTournament.Size = new System.Drawing.Size(164, 29);
            this.btnCreateTournament.TabIndex = 18;
            this.btnCreateTournament.Text = "Create Tournamet";
            this.btnCreateTournament.UseVisualStyleBackColor = true;
            this.btnCreateTournament.Click += new System.EventHandler(this.btnCreateTournament_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(435, 334);
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(581, 105);
            this.tbDescription.TabIndex = 17;
            this.tbDescription.Text = "";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(675, 311);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(790, 20);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(199, 20);
            this.lblEndDate.TabIndex = 15;
            this.lblEndDate.Text = "End Date of The Tournament";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(457, 20);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(205, 20);
            this.lblStartDate.TabIndex = 14;
            this.lblStartDate.Text = "Start Date of The Tournament";
            // 
            // mCalendarEnd
            // 
            this.mCalendarEnd.Location = new System.Drawing.Point(754, 49);
            this.mCalendarEnd.Name = "mCalendarEnd";
            this.mCalendarEnd.TabIndex = 13;
            // 
            // mCalendarStart
            // 
            this.mCalendarStart.Location = new System.Drawing.Point(435, 49);
            this.mCalendarStart.Name = "mCalendarStart";
            this.mCalendarStart.TabIndex = 12;
            // 
            // cbTournamentType
            // 
            this.cbTournamentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTournamentType.FormattingEnabled = true;
            this.cbTournamentType.Items.AddRange(new object[] {
            "RoundRobin",
            "DoubleRoundRobin"});
            this.cbTournamentType.Location = new System.Drawing.Point(186, 354);
            this.cbTournamentType.Name = "cbTournamentType";
            this.cbTournamentType.Size = new System.Drawing.Size(161, 28);
            this.cbTournamentType.TabIndex = 11;
            // 
            // cbSportType
            // 
            this.cbSportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSportType.FormattingEnabled = true;
            this.cbSportType.Items.AddRange(new object[] {
            "Badminton",
            "Tennis"});
            this.cbSportType.Location = new System.Drawing.Point(186, 282);
            this.cbSportType.Name = "cbSportType";
            this.cbSportType.Size = new System.Drawing.Size(156, 28);
            this.cbSportType.TabIndex = 10;
            // 
            // lblTournamentType
            // 
            this.lblTournamentType.AutoSize = true;
            this.lblTournamentType.Location = new System.Drawing.Point(37, 362);
            this.lblTournamentType.Name = "lblTournamentType";
            this.lblTournamentType.Size = new System.Drawing.Size(123, 20);
            this.lblTournamentType.TabIndex = 9;
            this.lblTournamentType.Text = "Tournament Type";
            // 
            // lblSportType
            // 
            this.lblSportType.AutoSize = true;
            this.lblSportType.Location = new System.Drawing.Point(53, 285);
            this.lblSportType.Name = "lblSportType";
            this.lblSportType.Size = new System.Drawing.Size(80, 20);
            this.lblSportType.TabIndex = 8;
            this.lblSportType.Text = "Sport Type";
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.AutoSize = true;
            this.lblMaxPlayers.Location = new System.Drawing.Point(53, 230);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(87, 20);
            this.lblMaxPlayers.TabIndex = 7;
            this.lblMaxPlayers.Text = "Max Players";
            // 
            // lblMinPlayers
            // 
            this.lblMinPlayers.AutoSize = true;
            this.lblMinPlayers.Location = new System.Drawing.Point(53, 168);
            this.lblMinPlayers.Name = "lblMinPlayers";
            this.lblMinPlayers.Size = new System.Drawing.Size(84, 20);
            this.lblMinPlayers.TabIndex = 6;
            this.lblMinPlayers.Text = "Min Players";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(53, 113);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 20);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Location = new System.Drawing.Point(28, 52);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(132, 20);
            this.lblTournamentName.TabIndex = 4;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // tbMinPlayers
            // 
            this.tbMinPlayers.Location = new System.Drawing.Point(186, 223);
            this.tbMinPlayers.Name = "tbMinPlayers";
            this.tbMinPlayers.Size = new System.Drawing.Size(156, 27);
            this.tbMinPlayers.TabIndex = 3;
            // 
            // tbMaxPlayers
            // 
            this.tbMaxPlayers.Location = new System.Drawing.Point(186, 168);
            this.tbMaxPlayers.Name = "tbMaxPlayers";
            this.tbMaxPlayers.Size = new System.Drawing.Size(156, 27);
            this.tbMaxPlayers.TabIndex = 2;
            // 
            // tbLocation
            // 
            this.tbLocation.Location = new System.Drawing.Point(186, 106);
            this.tbLocation.Name = "tbLocation";
            this.tbLocation.Size = new System.Drawing.Size(156, 27);
            this.tbLocation.TabIndex = 1;
            // 
            // tbTournamentName
            // 
            this.tbTournamentName.Location = new System.Drawing.Point(186, 49);
            this.tbTournamentName.Name = "tbTournamentName";
            this.tbTournamentName.Size = new System.Drawing.Size(156, 27);
            this.tbTournamentName.TabIndex = 0;
            // 
            // tabPageEmployeemanagement
            // 
            this.tabPageEmployeemanagement.Controls.Add(this.btnSignUp);
            this.tabPageEmployeemanagement.Controls.Add(this.lblPositionSU);
            this.tabPageEmployeemanagement.Controls.Add(this.cbPositionSU);
            this.tabPageEmployeemanagement.Controls.Add(this.lblEmailSU);
            this.tabPageEmployeemanagement.Controls.Add(this.textBox4);
            this.tabPageEmployeemanagement.Controls.Add(this.lblPasswordSU);
            this.tabPageEmployeemanagement.Controls.Add(this.lblUserNameSU);
            this.tabPageEmployeemanagement.Controls.Add(this.textBox1);
            this.tabPageEmployeemanagement.Controls.Add(this.textBox2);
            this.tabPageEmployeemanagement.Location = new System.Drawing.Point(4, 29);
            this.tabPageEmployeemanagement.Name = "tabPageEmployeemanagement";
            this.tabPageEmployeemanagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmployeemanagement.Size = new System.Drawing.Size(1043, 545);
            this.tabPageEmployeemanagement.TabIndex = 2;
            this.tabPageEmployeemanagement.Text = "EmployeeManagement";
            this.tabPageEmployeemanagement.UseVisualStyleBackColor = true;
            // 
            // lblPasswordSU
            // 
            this.lblPasswordSU.AutoSize = true;
            this.lblPasswordSU.Location = new System.Drawing.Point(143, 149);
            this.lblPasswordSU.Name = "lblPasswordSU";
            this.lblPasswordSU.Size = new System.Drawing.Size(73, 20);
            this.lblPasswordSU.TabIndex = 8;
            this.lblPasswordSU.Text = "Password:";
            // 
            // lblUserNameSU
            // 
            this.lblUserNameSU.AutoSize = true;
            this.lblUserNameSU.Location = new System.Drawing.Point(143, 66);
            this.lblUserNameSU.Name = "lblUserNameSU";
            this.lblUserNameSU.Size = new System.Drawing.Size(81, 20);
            this.lblUserNameSU.TabIndex = 7;
            this.lblUserNameSU.Text = "UserName:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(318, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 27);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(318, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(145, 27);
            this.textBox2.TabIndex = 5;
            // 
            // lblEmailSU
            // 
            this.lblEmailSU.AutoSize = true;
            this.lblEmailSU.Location = new System.Drawing.Point(143, 214);
            this.lblEmailSU.Name = "lblEmailSU";
            this.lblEmailSU.Size = new System.Drawing.Size(49, 20);
            this.lblEmailSU.TabIndex = 11;
            this.lblEmailSU.Text = "Email:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(318, 207);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(145, 27);
            this.textBox4.TabIndex = 9;
            // 
            // cbPositionSU
            // 
            this.cbPositionSU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPositionSU.FormattingEnabled = true;
            this.cbPositionSU.Items.AddRange(new object[] {
            "Admin",
            "HR"});
            this.cbPositionSU.Location = new System.Drawing.Point(318, 297);
            this.cbPositionSU.Name = "cbPositionSU";
            this.cbPositionSU.Size = new System.Drawing.Size(145, 28);
            this.cbPositionSU.TabIndex = 12;
            // 
            // lblPositionSU
            // 
            this.lblPositionSU.AutoSize = true;
            this.lblPositionSU.Location = new System.Drawing.Point(143, 300);
            this.lblPositionSU.Name = "lblPositionSU";
            this.lblPositionSU.Size = new System.Drawing.Size(64, 20);
            this.lblPositionSU.TabIndex = 13;
            this.lblPositionSU.Text = "Position:";
            // 
            // btnSignUp
            // 
            this.btnSignUp.Location = new System.Drawing.Point(342, 394);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(94, 29);
            this.btnSignUp.TabIndex = 14;
            this.btnSignUp.Text = "Sign Up";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // DesktopApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 591);
            this.Controls.Add(this.tabControl1);
            this.Name = "DesktopApp";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageTournament.ResumeLayout(false);
            this.tabPageTournament.PerformLayout();
            this.tabPageEmployeemanagement.ResumeLayout(false);
            this.tabPageEmployeemanagement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageLogin;
        private TabPage tabPageTournament;
        private TabPage tabPageEmployeemanagement;
        private TextBox tbMinPlayers;
        private TextBox tbMaxPlayers;
        private TextBox tbLocation;
        private TextBox tbTournamentName;
        private Label lblTournamentType;
        private Label lblSportType;
        private Label lblMaxPlayers;
        private Label lblMinPlayers;
        private Label lblLocation;
        private Label lblTournamentName;
        private ComboBox cbTournamentType;
        private ComboBox cbSportType;
        private Label lblDescription;
        private Label lblEndDate;
        private Label lblStartDate;
        private MonthCalendar mCalendarEnd;
        private MonthCalendar mCalendarStart;
        private Button btnCreateTournament;
        private RichTextBox tbDescription;
        private Label lblPassword;
        private Label lblUserName;
        private Button btnLogin;
        private TextBox tbPassword;
        private TextBox tbUserName;
        private Label lblEmailSU;
        private TextBox textBox4;
        private Label lblPasswordSU;
        private Label lblUserNameSU;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button btnSignUp;
        private Label lblPositionSU;
        private ComboBox cbPositionSU;
    }
}