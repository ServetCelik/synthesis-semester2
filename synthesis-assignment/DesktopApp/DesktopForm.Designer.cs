namespace DesktopApp
{
    partial class DesktopForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.tbUserNameLogin = new System.Windows.Forms.TextBox();
            this.tabTournament = new System.Windows.Forms.TabPage();
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
            this.tabEmployeeManagement = new System.Windows.Forms.TabPage();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblPositionSU = new System.Windows.Forms.Label();
            this.cbPositionSU = new System.Windows.Forms.ComboBox();
            this.lblEmailSU = new System.Windows.Forms.Label();
            this.tbEmailSU = new System.Windows.Forms.TextBox();
            this.lblPasswordSU = new System.Windows.Forms.Label();
            this.lblUserNameSU = new System.Windows.Forms.Label();
            this.tbPasswordSU = new System.Windows.Forms.TextBox();
            this.tbUserNameSU = new System.Windows.Forms.TextBox();
            this.tabGenerateSchedule = new System.Windows.Forms.TabPage();
            this.btnDeleteTournament = new System.Windows.Forms.Button();
            this.btnRegisterScore = new System.Windows.Forms.Button();
            this.btnShowMatches = new System.Windows.Forms.Button();
            this.dgvMatches = new System.Windows.Forms.DataGridView();
            this.dgvPlayer1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPlayer2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTournaments = new System.Windows.Forms.DataGridView();
            this.dgvTournamentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSportType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTournamentSystem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGenerateMatches = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabTournament.SuspendLayout();
            this.tabEmployeeManagement.SuspendLayout();
            this.tabGenerateSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTournaments)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabLogin);
            this.tabControl.Controls.Add(this.tabTournament);
            this.tabControl.Controls.Add(this.tabEmployeeManagement);
            this.tabControl.Controls.Add(this.tabGenerateSchedule);
            this.tabControl.Location = new System.Drawing.Point(9, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1051, 537);
            this.tabControl.TabIndex = 1;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.AliceBlue;
            this.tabLogin.Controls.Add(this.lblPassword);
            this.tabLogin.Controls.Add(this.lblUserName);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.tbPasswordLogin);
            this.tabLogin.Controls.Add(this.tbUserNameLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 29);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(1043, 504);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(265, 219);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 20);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(265, 136);
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
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Location = new System.Drawing.Point(437, 209);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.Size = new System.Drawing.Size(125, 27);
            this.tbPasswordLogin.TabIndex = 1;
            this.tbPasswordLogin.UseSystemPasswordChar = true;
            // 
            // tbUserNameLogin
            // 
            this.tbUserNameLogin.Location = new System.Drawing.Point(437, 133);
            this.tbUserNameLogin.Name = "tbUserNameLogin";
            this.tbUserNameLogin.Size = new System.Drawing.Size(125, 27);
            this.tbUserNameLogin.TabIndex = 0;
            // 
            // tabTournament
            // 
            this.tabTournament.Controls.Add(this.btnCreateTournament);
            this.tabTournament.Controls.Add(this.tbDescription);
            this.tabTournament.Controls.Add(this.lblDescription);
            this.tabTournament.Controls.Add(this.lblEndDate);
            this.tabTournament.Controls.Add(this.lblStartDate);
            this.tabTournament.Controls.Add(this.mCalendarEnd);
            this.tabTournament.Controls.Add(this.mCalendarStart);
            this.tabTournament.Controls.Add(this.cbTournamentType);
            this.tabTournament.Controls.Add(this.cbSportType);
            this.tabTournament.Controls.Add(this.lblTournamentType);
            this.tabTournament.Controls.Add(this.lblSportType);
            this.tabTournament.Controls.Add(this.lblMaxPlayers);
            this.tabTournament.Controls.Add(this.lblMinPlayers);
            this.tabTournament.Controls.Add(this.lblLocation);
            this.tabTournament.Controls.Add(this.lblTournamentName);
            this.tabTournament.Controls.Add(this.tbMinPlayers);
            this.tabTournament.Controls.Add(this.tbMaxPlayers);
            this.tabTournament.Controls.Add(this.tbLocation);
            this.tabTournament.Controls.Add(this.tbTournamentName);
            this.tabTournament.Location = new System.Drawing.Point(4, 29);
            this.tabTournament.Name = "tabTournament";
            this.tabTournament.Padding = new System.Windows.Forms.Padding(3);
            this.tabTournament.Size = new System.Drawing.Size(1043, 504);
            this.tabTournament.TabIndex = 1;
            this.tabTournament.Text = "Tournament";
            this.tabTournament.UseVisualStyleBackColor = true;
            // 
            // btnCreateTournament
            // 
            this.btnCreateTournament.Location = new System.Drawing.Point(639, 469);
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
            this.lblDescription.Location = new System.Drawing.Point(678, 314);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(85, 20);
            this.lblDescription.TabIndex = 16;
            this.lblDescription.Text = "Description";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(793, 23);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(199, 20);
            this.lblEndDate.TabIndex = 15;
            this.lblEndDate.Text = "End Date of The Tournament";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(460, 23);
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
            "Table Tennis"});
            this.cbSportType.Location = new System.Drawing.Point(186, 282);
            this.cbSportType.Name = "cbSportType";
            this.cbSportType.Size = new System.Drawing.Size(156, 28);
            this.cbSportType.TabIndex = 10;
            // 
            // lblTournamentType
            // 
            this.lblTournamentType.AutoSize = true;
            this.lblTournamentType.Location = new System.Drawing.Point(40, 365);
            this.lblTournamentType.Name = "lblTournamentType";
            this.lblTournamentType.Size = new System.Drawing.Size(123, 20);
            this.lblTournamentType.TabIndex = 9;
            this.lblTournamentType.Text = "Tournament Type";
            // 
            // lblSportType
            // 
            this.lblSportType.AutoSize = true;
            this.lblSportType.Location = new System.Drawing.Point(56, 288);
            this.lblSportType.Name = "lblSportType";
            this.lblSportType.Size = new System.Drawing.Size(80, 20);
            this.lblSportType.TabIndex = 8;
            this.lblSportType.Text = "Sport Type";
            // 
            // lblMaxPlayers
            // 
            this.lblMaxPlayers.AutoSize = true;
            this.lblMaxPlayers.Location = new System.Drawing.Point(56, 233);
            this.lblMaxPlayers.Name = "lblMaxPlayers";
            this.lblMaxPlayers.Size = new System.Drawing.Size(87, 20);
            this.lblMaxPlayers.TabIndex = 7;
            this.lblMaxPlayers.Text = "Max Players";
            // 
            // lblMinPlayers
            // 
            this.lblMinPlayers.AutoSize = true;
            this.lblMinPlayers.Location = new System.Drawing.Point(56, 171);
            this.lblMinPlayers.Name = "lblMinPlayers";
            this.lblMinPlayers.Size = new System.Drawing.Size(84, 20);
            this.lblMinPlayers.TabIndex = 6;
            this.lblMinPlayers.Text = "Min Players";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(56, 116);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(66, 20);
            this.lblLocation.TabIndex = 5;
            this.lblLocation.Text = "Location";
            // 
            // lblTournamentName
            // 
            this.lblTournamentName.AutoSize = true;
            this.lblTournamentName.Location = new System.Drawing.Point(31, 55);
            this.lblTournamentName.Name = "lblTournamentName";
            this.lblTournamentName.Size = new System.Drawing.Size(132, 20);
            this.lblTournamentName.TabIndex = 4;
            this.lblTournamentName.Text = "Tournament Name";
            // 
            // tbMinPlayers
            // 
            this.tbMinPlayers.Location = new System.Drawing.Point(186, 168);
            this.tbMinPlayers.Name = "tbMinPlayers";
            this.tbMinPlayers.Size = new System.Drawing.Size(156, 27);
            this.tbMinPlayers.TabIndex = 3;
            // 
            // tbMaxPlayers
            // 
            this.tbMaxPlayers.Location = new System.Drawing.Point(186, 226);
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
            // tabEmployeeManagement
            // 
            this.tabEmployeeManagement.Controls.Add(this.btnSignUp);
            this.tabEmployeeManagement.Controls.Add(this.lblPositionSU);
            this.tabEmployeeManagement.Controls.Add(this.cbPositionSU);
            this.tabEmployeeManagement.Controls.Add(this.lblEmailSU);
            this.tabEmployeeManagement.Controls.Add(this.tbEmailSU);
            this.tabEmployeeManagement.Controls.Add(this.lblPasswordSU);
            this.tabEmployeeManagement.Controls.Add(this.lblUserNameSU);
            this.tabEmployeeManagement.Controls.Add(this.tbPasswordSU);
            this.tabEmployeeManagement.Controls.Add(this.tbUserNameSU);
            this.tabEmployeeManagement.Location = new System.Drawing.Point(4, 29);
            this.tabEmployeeManagement.Name = "tabEmployeeManagement";
            this.tabEmployeeManagement.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmployeeManagement.Size = new System.Drawing.Size(1043, 504);
            this.tabEmployeeManagement.TabIndex = 2;
            this.tabEmployeeManagement.Text = "EmployeeManagement";
            this.tabEmployeeManagement.UseVisualStyleBackColor = true;
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
            // lblPositionSU
            // 
            this.lblPositionSU.AutoSize = true;
            this.lblPositionSU.Location = new System.Drawing.Point(146, 303);
            this.lblPositionSU.Name = "lblPositionSU";
            this.lblPositionSU.Size = new System.Drawing.Size(64, 20);
            this.lblPositionSU.TabIndex = 13;
            this.lblPositionSU.Text = "Position:";
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
            // lblEmailSU
            // 
            this.lblEmailSU.AutoSize = true;
            this.lblEmailSU.Location = new System.Drawing.Point(146, 217);
            this.lblEmailSU.Name = "lblEmailSU";
            this.lblEmailSU.Size = new System.Drawing.Size(49, 20);
            this.lblEmailSU.TabIndex = 11;
            this.lblEmailSU.Text = "Email:";
            // 
            // tbEmailSU
            // 
            this.tbEmailSU.Location = new System.Drawing.Point(318, 207);
            this.tbEmailSU.Name = "tbEmailSU";
            this.tbEmailSU.Size = new System.Drawing.Size(145, 27);
            this.tbEmailSU.TabIndex = 9;
            // 
            // lblPasswordSU
            // 
            this.lblPasswordSU.AutoSize = true;
            this.lblPasswordSU.Location = new System.Drawing.Point(146, 152);
            this.lblPasswordSU.Name = "lblPasswordSU";
            this.lblPasswordSU.Size = new System.Drawing.Size(73, 20);
            this.lblPasswordSU.TabIndex = 8;
            this.lblPasswordSU.Text = "Password:";
            // 
            // lblUserNameSU
            // 
            this.lblUserNameSU.AutoSize = true;
            this.lblUserNameSU.Location = new System.Drawing.Point(146, 69);
            this.lblUserNameSU.Name = "lblUserNameSU";
            this.lblUserNameSU.Size = new System.Drawing.Size(81, 20);
            this.lblUserNameSU.TabIndex = 7;
            this.lblUserNameSU.Text = "UserName:";
            // 
            // tbPasswordSU
            // 
            this.tbPasswordSU.Location = new System.Drawing.Point(318, 142);
            this.tbPasswordSU.Name = "tbPasswordSU";
            this.tbPasswordSU.Size = new System.Drawing.Size(145, 27);
            this.tbPasswordSU.TabIndex = 6;
            this.tbPasswordSU.UseSystemPasswordChar = true;
            // 
            // tbUserNameSU
            // 
            this.tbUserNameSU.Location = new System.Drawing.Point(318, 66);
            this.tbUserNameSU.Name = "tbUserNameSU";
            this.tbUserNameSU.Size = new System.Drawing.Size(145, 27);
            this.tbUserNameSU.TabIndex = 5;
            // 
            // tabGenerateSchedule
            // 
            this.tabGenerateSchedule.Controls.Add(this.btnDeleteTournament);
            this.tabGenerateSchedule.Controls.Add(this.btnRegisterScore);
            this.tabGenerateSchedule.Controls.Add(this.btnShowMatches);
            this.tabGenerateSchedule.Controls.Add(this.dgvMatches);
            this.tabGenerateSchedule.Controls.Add(this.dgvTournaments);
            this.tabGenerateSchedule.Controls.Add(this.btnGenerateMatches);
            this.tabGenerateSchedule.Location = new System.Drawing.Point(4, 29);
            this.tabGenerateSchedule.Name = "tabGenerateSchedule";
            this.tabGenerateSchedule.Size = new System.Drawing.Size(1043, 504);
            this.tabGenerateSchedule.TabIndex = 3;
            this.tabGenerateSchedule.Text = "GenerateSchedule";
            this.tabGenerateSchedule.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTournament
            // 
            this.btnDeleteTournament.Location = new System.Drawing.Point(392, 197);
            this.btnDeleteTournament.Name = "btnDeleteTournament";
            this.btnDeleteTournament.Size = new System.Drawing.Size(189, 29);
            this.btnDeleteTournament.TabIndex = 35;
            this.btnDeleteTournament.Text = "Delete Tournament";
            this.btnDeleteTournament.UseVisualStyleBackColor = true;
            this.btnDeleteTournament.Click += new System.EventHandler(this.btnDeleteTournament_Click);
            // 
            // btnRegisterScore
            // 
            this.btnRegisterScore.Location = new System.Drawing.Point(416, 462);
            this.btnRegisterScore.Name = "btnRegisterScore";
            this.btnRegisterScore.Size = new System.Drawing.Size(136, 39);
            this.btnRegisterScore.TabIndex = 34;
            this.btnRegisterScore.Text = "Register Score";
            this.btnRegisterScore.UseVisualStyleBackColor = true;
            this.btnRegisterScore.Click += new System.EventHandler(this.btnRegisterScore_Click);
            // 
            // btnShowMatches
            // 
            this.btnShowMatches.Location = new System.Drawing.Point(742, 197);
            this.btnShowMatches.Name = "btnShowMatches";
            this.btnShowMatches.Size = new System.Drawing.Size(147, 29);
            this.btnShowMatches.TabIndex = 33;
            this.btnShowMatches.Text = "Show Matches";
            this.btnShowMatches.UseVisualStyleBackColor = true;
            this.btnShowMatches.Click += new System.EventHandler(this.btnShowMatches_Click);
            // 
            // dgvMatches
            // 
            this.dgvMatches.AllowUserToAddRows = false;
            this.dgvMatches.AllowUserToDeleteRows = false;
            this.dgvMatches.AllowUserToResizeColumns = false;
            this.dgvMatches.AllowUserToResizeRows = false;
            this.dgvMatches.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatches.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMatches.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvMatches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatches.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPlayer1,
            this.dgvPlayer2,
            this.dgvMatchTime,
            this.dgvScore});
            this.dgvMatches.Location = new System.Drawing.Point(15, 242);
            this.dgvMatches.MultiSelect = false;
            this.dgvMatches.Name = "dgvMatches";
            this.dgvMatches.RowHeadersVisible = false;
            this.dgvMatches.RowHeadersWidth = 51;
            this.dgvMatches.RowTemplate.Height = 29;
            this.dgvMatches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatches.Size = new System.Drawing.Size(1025, 214);
            this.dgvMatches.TabIndex = 32;
            // 
            // dgvPlayer1
            // 
            this.dgvPlayer1.HeaderText = "Player1";
            this.dgvPlayer1.MinimumWidth = 6;
            this.dgvPlayer1.Name = "dgvPlayer1";
            this.dgvPlayer1.ReadOnly = true;
            // 
            // dgvPlayer2
            // 
            this.dgvPlayer2.HeaderText = "Player2";
            this.dgvPlayer2.MinimumWidth = 8;
            this.dgvPlayer2.Name = "dgvPlayer2";
            this.dgvPlayer2.ReadOnly = true;
            // 
            // dgvMatchTime
            // 
            this.dgvMatchTime.HeaderText = "Date";
            this.dgvMatchTime.MinimumWidth = 8;
            this.dgvMatchTime.Name = "dgvMatchTime";
            this.dgvMatchTime.ReadOnly = true;
            // 
            // dgvScore
            // 
            this.dgvScore.HeaderText = "Score";
            this.dgvScore.MinimumWidth = 8;
            this.dgvScore.Name = "dgvScore";
            this.dgvScore.ReadOnly = true;
            // 
            // dgvTournaments
            // 
            this.dgvTournaments.AllowUserToAddRows = false;
            this.dgvTournaments.AllowUserToDeleteRows = false;
            this.dgvTournaments.AllowUserToResizeColumns = false;
            this.dgvTournaments.AllowUserToResizeRows = false;
            this.dgvTournaments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTournaments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvTournaments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTournaments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTournaments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvTournamentName,
            this.dgvSportType,
            this.dgvTournamentSystem,
            this.dgvLocation,
            this.dgvStartDate,
            this.dgvPlayers,
            this.dgvStatus});
            this.dgvTournaments.Location = new System.Drawing.Point(15, 9);
            this.dgvTournaments.MultiSelect = false;
            this.dgvTournaments.Name = "dgvTournaments";
            this.dgvTournaments.RowHeadersVisible = false;
            this.dgvTournaments.RowHeadersWidth = 51;
            this.dgvTournaments.RowTemplate.Height = 29;
            this.dgvTournaments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTournaments.Size = new System.Drawing.Size(1025, 172);
            this.dgvTournaments.TabIndex = 31;
            // 
            // dgvTournamentName
            // 
            this.dgvTournamentName.HeaderText = "Tournament Name";
            this.dgvTournamentName.MinimumWidth = 6;
            this.dgvTournamentName.Name = "dgvTournamentName";
            this.dgvTournamentName.ReadOnly = true;
            // 
            // dgvSportType
            // 
            this.dgvSportType.HeaderText = "Sport Type";
            this.dgvSportType.MinimumWidth = 8;
            this.dgvSportType.Name = "dgvSportType";
            this.dgvSportType.ReadOnly = true;
            // 
            // dgvTournamentSystem
            // 
            this.dgvTournamentSystem.HeaderText = "Tournament System";
            this.dgvTournamentSystem.MinimumWidth = 8;
            this.dgvTournamentSystem.Name = "dgvTournamentSystem";
            this.dgvTournamentSystem.ReadOnly = true;
            // 
            // dgvLocation
            // 
            this.dgvLocation.HeaderText = "Location";
            this.dgvLocation.MinimumWidth = 8;
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.ReadOnly = true;
            // 
            // dgvStartDate
            // 
            this.dgvStartDate.HeaderText = "Start Date";
            this.dgvStartDate.MinimumWidth = 8;
            this.dgvStartDate.Name = "dgvStartDate";
            this.dgvStartDate.ReadOnly = true;
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.HeaderText = "Current/Min/Max players";
            this.dgvPlayers.MinimumWidth = 8;
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            // 
            // dgvStatus
            // 
            this.dgvStatus.HeaderText = "Status";
            this.dgvStatus.MinimumWidth = 8;
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.ReadOnly = true;
            // 
            // btnGenerateMatches
            // 
            this.btnGenerateMatches.Location = new System.Drawing.Point(15, 197);
            this.btnGenerateMatches.Name = "btnGenerateMatches";
            this.btnGenerateMatches.Size = new System.Drawing.Size(189, 29);
            this.btnGenerateMatches.TabIndex = 1;
            this.btnGenerateMatches.Text = "   ";
            this.btnGenerateMatches.UseVisualStyleBackColor = true;
            this.btnGenerateMatches.Click += new System.EventHandler(this.btnGenerateMatches_Click);
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1072, 556);
            this.Controls.Add(this.tabControl);
            this.Name = "DesktopForm";
            this.Text = "DesktopForm";
            this.tabControl.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabTournament.ResumeLayout(false);
            this.tabTournament.PerformLayout();
            this.tabEmployeeManagement.ResumeLayout(false);
            this.tabEmployeeManagement.PerformLayout();
            this.tabGenerateSchedule.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTournaments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl;
        private TabPage tabLogin;
        private Label lblPassword;
        private Label lblUserName;
        private Button btnLogin;
        private TextBox tbPasswordLogin;
        private TextBox tbUserNameLogin;
        private TabPage tabTournament;
        private Button btnCreateTournament;
        private RichTextBox tbDescription;
        private Label lblDescription;
        private Label lblEndDate;
        private Label lblStartDate;
        private MonthCalendar mCalendarEnd;
        private MonthCalendar mCalendarStart;
        private ComboBox cbTournamentType;
        private ComboBox cbSportType;
        private Label lblTournamentType;
        private Label lblSportType;
        private Label lblMaxPlayers;
        private Label lblMinPlayers;
        private Label lblLocation;
        private Label lblTournamentName;
        private TextBox tbMinPlayers;
        private TextBox tbMaxPlayers;
        private TextBox tbLocation;
        private TextBox tbTournamentName;
        private TabPage tabEmployeeManagement;
        private Button btnSignUp;
        private Label lblPositionSU;
        private ComboBox cbPositionSU;
        private Label lblEmailSU;
        private TextBox tbEmailSU;
        private Label lblPasswordSU;
        private Label lblUserNameSU;
        private TextBox tbPasswordSU;
        private TextBox tbUserNameSU;
        private TabPage tabGenerateSchedule;
        private Button btnGenerateMatches;
        private DataGridView dgvTournaments;
        private DataGridViewTextBoxColumn dgvTournamentName;
        private DataGridViewTextBoxColumn dgvSportType;
        private DataGridViewTextBoxColumn dgvTournamentSystem;
        private DataGridViewTextBoxColumn dgvLocation;
        private DataGridViewTextBoxColumn dgvStartDate;
        private DataGridViewTextBoxColumn dgvPlayers;
        private DataGridViewTextBoxColumn dgvStatus;
        private Button btnShowMatches;
        private DataGridView dgvMatches;
        private DataGridViewTextBoxColumn dgvPlayer1;
        private DataGridViewTextBoxColumn dgvPlayer2;
        private DataGridViewTextBoxColumn dgvMatchTime;
        private DataGridViewTextBoxColumn dgvScore;
        private Button btnRegisterScore;
        private Button btnDeleteTournament;
    }
}