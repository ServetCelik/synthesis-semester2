using LogicLayer.Entities;
using LogicLayer.Enums;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestTournamentClass
    {
        [TestMethod]
        public void TestConstructor()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);
            
            Assert.IsNotNull(tournament);
        }
        [TestMethod]
        public void TestIdProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.Id,"1");
        }
        [TestMethod]
        public void TestTournamentNameProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.TournamentName, "a");
        }
        [TestMethod]
        public void TestSportTypeProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.SportType, "Badminton");
        }
        [TestMethod]
        public void TestTournamentTypeProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.TournamentType, "RoundRobin");
        }
        [TestMethod]
        public void TestDescriptionProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.Description, "None");
        }
        [TestMethod]
        public void TestLocationProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.Location, "noWhere");
        }
        [TestMethod]
        public void TestStartDateProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.StartDate.Date, DateTime.Now.AddDays(100).Date);
        }
        [TestMethod]
        public void TestEndDateProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.EndDate.Date, DateTime.Now.AddDays(110).Date);
        }
        [TestMethod]
        public void TestMinPlayersProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.MinPlayers, 2);
        }
        [TestMethod]
        public void TestMaxPlayersProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.MaxPlayers, 6);
        }
        [TestMethod]
        public void TestPlayersProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.Players.Count, 0);
        }
        [TestMethod]
        public void TestWhoCreatedProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.WhoCreated, staff);
        }
        [TestMethod]
        public void TestMatchesProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.Matches.Count, 0);
        }
        [TestMethod]
        public void TestStatusProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);

            Assert.AreEqual(tournament.Status, Status.applicable);
        }
        [TestMethod]
        public void TestAddPlayer()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);
            bool first =tournament.AddPlayer(new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0));
            bool second = tournament.AddPlayer(new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0));
            Assert.AreNotEqual(first,second);
        }
        [TestMethod]
        public void TestDeletePlayer()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);
            bool first = tournament.AddPlayer(new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0));
            bool second = tournament.DeletePlayer(new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0));
            Assert.AreEqual(true, second);
        }
        [TestMethod]
        public void TestGenerateMatches()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(6), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);
            tournament.AddPlayer(new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0));
            tournament.AddPlayer(new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45));
            tournament.AddPlayer(new Player("3", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0));
            tournament.AddPlayer(new Player("4", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45));
            tournament.UpdateStatus();
            tournament.GenerateMatches();
            Assert.AreEqual(tournament.Matches.Count, 6);
        }
        [TestMethod]
        public void TestUpdateStatus()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            Tournament tournament = new Tournament("1", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(6), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable);
            tournament.UpdateStatus();

            Assert.AreEqual(tournament.Status, Status.canceled);
        }

    }
}
