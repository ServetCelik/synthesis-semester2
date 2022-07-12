using DataAccessLayer.Classes;
using LogicLayer.Entities;
using LogicLayer.Enums;
using LogicLayer.Exceptions;
using LogicLayer.LogicClasses;
using LogicLayer.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp
{
    public partial class DesktopForm : Form
    {
        static TournamentDAL tournamentDAL = new TournamentDAL();
        TournamentAdministrator tournamentAdministrator;
        static UserDAL userDAL = new UserDAL();
        UserAdministrator userAdministator;
        Tournament selectedTournament;

        Staff loggedInStaff;
        
        public DesktopForm()
        {
            try
            {
                InitializeComponent();                
                userAdministator = new UserAdministrator(userDAL);
                tournamentAdministrator = new TournamentAdministrator(tournamentDAL);
                updateTournamentDGV();
                tabHide();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }            
        }

        
         
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = tbUserNameLogin.Text;
            string password = tbPasswordLogin.Text;            

            if (string.IsNullOrEmpty(userName)||string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Pls Fill Username and Password");
            }
            else
            {
                try
                {

                    if (userAdministator.CheckLogin(userName, password))
                    {
                        User user = userAdministator.FindUserByUserName(tbUserNameLogin.Text);
                        if (user is Staff)
                        {
                            loggedInStaff = (Staff)user;
                            tabShow();
                        }
                        else
                        {
                            MessageBox.Show("Only for Staffs");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password");
                    }

                }
                catch (AuthenticationException)
                {
                    MessageBox.Show(new AuthenticationException().Message.ToString());
                    tbUserNameLogin.Text = string.Empty;
                    tbPasswordLogin.Text = string.Empty;
                }
                catch (System.NullReferenceException)
                {
                    MessageBox.Show(new LogicLayer.Exceptions.NullReferenceException().Message.ToString());
                    tbUserNameLogin.Text = string.Empty;
                    tbPasswordLogin.Text = string.Empty;
                }
                catch (Exception ex)
                {
                    tbUserNameLogin.Text = string.Empty;
                    tbPasswordLogin.Text = string.Empty;
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString();
            string name = tbTournamentName.Text;
            string location = tbLocation.Text;
            string sportType = cbSportType.Text;
            string tournamentType = cbTournamentType.Text;
            string description = tbDescription.Text;
            int minPlayers;
            bool tryMinValue = int.TryParse(tbMinPlayers.Text, out minPlayers);
            int maxPlayers;
            bool tryMaxValue = int.TryParse(tbMaxPlayers.Text, out maxPlayers);

            DateTime startDate = mCalendarStart.SelectionRange.Start;
            DateTime endDate = mCalendarEnd.SelectionRange.Start;
            if (tryMaxValue & tryMinValue & !string.IsNullOrEmpty(name) & !string.IsNullOrEmpty(location) & !string.IsNullOrEmpty(sportType) & !string.IsNullOrEmpty(tournamentType) & !string.IsNullOrEmpty(description))
            {
                Tournament tournament = new Tournament(id, name, sportType, tournamentType, description, location, startDate, endDate, minPlayers, maxPlayers, loggedInStaff, Status.applicable);
                tournamentAdministrator.CreateNewTournament(tournament);
                updateTournamentDGV();
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Try again and Fill all fields");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString();
            string name = tbUserNameSU.Text;
            string password = tbPasswordSU.Text;
            string salt = Guid.NewGuid().ToString();
            string hashedPassword = PasswordHasher.sha256_hash(password + salt);
            string email = tbEmailSU.Text;
            string position = cbPositionSU.Text;
            if (!string.IsNullOrEmpty(name)& !string.IsNullOrEmpty(password) & !string.IsNullOrEmpty(email) & !string.IsNullOrEmpty(position) )
            {
                Staff newUser = new Staff(id, name, hashedPassword, salt, email, position);

                if (userAdministator.CheckIdExistence(newUser))
                {
                    MessageBox.Show("Pls Try Again");
                }
                else if(userAdministator.CheckEmailExistence(newUser))
                {
                    MessageBox.Show("This Email is Used By Another User");
                }
                else if (userAdministator.CheckUserNameExistence(newUser))
                {
                    MessageBox.Show("This Username is Used By Another User");
                }
                else
                {
                    userAdministator.CreateUser(newUser);
                    MessageBox.Show("Success");
                }
            }
            else
            {
                MessageBox.Show("Pls Fill All Fields");
            }
            //Staff staff = new Staff(id, name, hashedPassword, salt, email, position);

            
        }

        private void btnGenerateMatches_Click(object sender, EventArgs e)
        {

            if (dgvTournaments.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Pls select an tournament");
            }
            else
            {
                int selectedIndex = dgvTournaments.CurrentCell.RowIndex;
                Tournament tournament = tournamentAdministrator.GetTournamentList()[selectedIndex];
                if (tournament.Matches.Count==0)
                {
                    if (tournamentAdministrator.GenerateMatches(tournament))
                    {
                        UpdateMatchList();
                        MessageBox.Show("Generated");
                    }
                    else
                    {
                        MessageBox.Show("Tournament status should be inapplicable and joined players should be at least the same amount of min player requirement");
                    }                 
                    
                }
                else
                {
                    MessageBox.Show("The have already been generated");
                }               

            }
        }
        private void updateTournamentDGV()
        {
            dgvTournaments.Rows.Clear();
            List<Tournament> tournamentList = tournamentAdministrator.GetTournamentList();
            foreach (var item in tournamentList)
            {
                string players = $"{item.Players.Count}/{item.MinPlayers}/{item.MaxPlayers}";
                dgvTournaments.Rows.Add(item.TournamentName, item.SportType, item.TournamentType, item.Location, item.StartDate.ToString("MM/dd/yyyy"), players, item.Status.ToString());
            }
        }

        private void btnShowMatches_Click(object sender, EventArgs e)
        {
            UpdateMatchList();
        }

        private void btnRegisterScore_Click(object sender, EventArgs e)
        {            
            if (dgvMatches.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvMatches.CurrentCell.RowIndex;

                Match selectedMatch = selectedTournament.Matches[selectedIndex];
                AddScore addScore = new AddScore(tournamentAdministrator, userAdministator, selectedMatch, this);
                addScore.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pls select an tournament");
            }

        }

        private void btnDeleteTournament_Click(object sender, EventArgs e)
        {
            if (dgvTournaments.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Pls select an tournament");
            }
            else
            {
                int selectedIndex = dgvTournaments.CurrentCell.RowIndex;                
                Tournament tournament = tournamentAdministrator.GetTournamentList()[selectedIndex];
                tournamentAdministrator.DeleteTournament(tournament);
                updateTournamentDGV();

                MessageBox.Show("Deleted");      
            }
        }
        public void UpdateMatchList()
        {
            dgvMatches.Rows.Clear();

            if (dgvTournaments.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Pls select an tournament");
            }
            else
            {
                int selectedIndex = dgvTournaments.CurrentCell.RowIndex;
                selectedTournament = tournamentAdministrator.GetTournamentList()[selectedIndex];
                dgvMatches.Rows.Clear();

                foreach (var item in selectedTournament.Matches)
                {
                    string score = item.ShowScores();                 

                    dgvMatches.Rows.Add(item.Player1.UserName, item.Player2.UserName, item.Date.ToString("MM/dd/yyyy"), score);
                }
            }
        }
        private void tabHide()
        {
            tabControl.TabPages.Remove(tabTournament);
            tabControl.TabPages.Remove(tabEmployeeManagement);
            tabControl.TabPages.Remove(tabGenerateSchedule);
        }
        private void tabShow()
        {
            tabControl.TabPages.Remove(tabLogin);
            tabControl.TabPages.Add(tabTournament);            
            tabControl.TabPages.Add(tabGenerateSchedule);
            if (loggedInStaff.Role=="HR")
            {
                tabControl.TabPages.Add(tabEmployeeManagement);
            }
        }
    }
}
