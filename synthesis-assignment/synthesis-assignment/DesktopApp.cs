using DataAccessLayer.Classes;
using LogicLayer.Entities;
using LogicLayer.Enums;
using LogicLayer.Exceptions;
using LogicLayer.LogicClasses;
using LogicLayer.Systems;
using LogicLayer.Utility;

namespace synthesis_assignment
{
    public partial class DesktopApp : Form
    {
        static TournamentDAL tournamentDAL = new TournamentDAL();
        TournamentAdministrator tournamentAdministrator = new TournamentAdministrator(tournamentDAL);
        static UserDAL userDAL = new UserDAL();
        UserAdministrator userAdministator = new UserAdministrator(userDAL);
        AuthenticationManager authenticationManager;
        List<User> us;


        Staff loggedInStaff;
       
        
        public DesktopApp()
        {
            InitializeComponent();
            //us = userAdministator.GetUsers();
            //userAdministator.DummyData();
            //users = userAdministator.GetUsers();
            //authenticationManager  = new AuthenticationManager(userAdministator);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Clear();
            //RoundRobin roundrobin = new RoundRobin();
            //Staff staff = new Staff(1,"","","","");
            //tournamentAdministrator.GenerateMatches(1, "firstTournament", "tennis", "DoubleRoundRobin", "none", "nowhere", DateOnly.FromDateTime(DateTime.Now), 5,10, users,staff, LogicLayer.Enums.Status.applicable);
            //tournamentList = tournamentAdministrator.GetTournaments();
            //List<Match> matches = tournamentList[0].Matches;

            //foreach (Match match in matches)
            //{
            //    listBox1.Items.Add($"{match.Player1.Id} vs {match.Player2.Id}");
            //}
        }

        private void btnCreateTournament_Click(object sender, EventArgs e)
        {            
            //string id = Guid.NewGuid().ToString();
            //string name = tbTournamentName.Text;
            //string location = tbLocation.Text;
            //string sportType = cbSportType.Text;
            //string tournamentType = cbTournamentType.Text;
            //string description = tbDescription.Text;
            //int minPlayers;
            //bool tryMinValue = int.TryParse(tbMinPlayers.Text, out minPlayers);
            //int maxPlayers;
            //bool tryMaxValue = int.TryParse(tbMaxPlayers.Text, out maxPlayers);

            //DateOnly startDate = DateOnly.FromDateTime(mCalendarStart.SelectionRange.Start);
            //DateOnly endDate = DateOnly.FromDateTime(mCalendarEnd.SelectionRange.Start);
            //if (tryMaxValue & tryMinValue & !string.IsNullOrEmpty(name) & !string.IsNullOrEmpty(location) & !string.IsNullOrEmpty(sportType) & !string.IsNullOrEmpty(tournamentType) & !string.IsNullOrEmpty(description))
            //{
            //    Tournament tournament = new Tournament(id, name, sportType, tournamentType, description, location, startDate, endDate, minPlayers, maxPlayers, loggedInStaff, Status.applicable);
            //    tournamentAdministrator.CreateNewTournament(tournament);
            //}
            //else
            //{
            //    MessageBox.Show("No");
            //}
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        //    string userName = tbUserName.Text;
        //    string password = tbPassword.Text;
            

        //    try
        //    {
        //        if (userAdministator.CheckLogin(userName, password))
        //        {
        //            loggedInStaff = (Staff)userAdministator.FindUserByUserName(tbUserName.Text);                    
        //        }
                
        //    }
        //    catch (AuthenticationException)
        //    {        
        //        throw new EntityNotFoundException();
        //    }
        //    catch (EntityNotFoundException)
        //    {
        //        throw new EntityNotFoundException();
        //    }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //string id = Guid.NewGuid().ToString();
            //string name = tbUserName.Text;
            //string password = tbPassword.Text;
            //string salt = Guid.NewGuid().ToString();
            //string hashedPassword = PasswordHasher.sha256_hash(password + salt);
            //string email = tbPassword.Text;
            //string position = cbPositionSU.Text;
            //Staff staff = new Staff(id, name, hashedPassword, salt, email,position);

            //userAdministator.CreateUser(staff);
        }
    }
}