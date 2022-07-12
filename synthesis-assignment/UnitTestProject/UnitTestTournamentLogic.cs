using DataAccessLayer.Classes;
using LogicLayer.Entities;
using LogicLayer.LogicClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestTournamentLogic
    {
        private static MockTournamentDAL mockDAL = new MockTournamentDAL();
        private readonly TournamentAdministrator tournamentAdmin = new TournamentAdministrator(mockDAL);

        [TestMethod]
        public void TestConstructor()
        {
            TournamentAdministrator tA = new TournamentAdministrator(new MockTournamentDAL());
            Assert.ReferenceEquals(tA, tournamentAdmin);
        }
        [TestMethod]
        public void TestGetTournamentList()
        {
            var tournaments = tournamentAdmin.GetTournamentList();

            Assert.AreEqual(3, tournaments.Count);
        }

        [TestMethod]
        public void TestUpdateTournamentList()
        {
            var tournaments = tournamentAdmin.GetTournamentList();
            tournaments.RemoveRange(0, 3);
            tournamentAdmin.UpdateTournamentList();

            Assert.AreEqual(3, tournaments.Count);
        }
        [TestMethod]
        public void TestGetMatchesOfATournament()
        {
            var theTournament = tournamentAdmin.GetTournamentList()[0];
            var matches = tournamentAdmin.GetMatchesOfATournament(theTournament);
            var numberOfMatches = matches.Count;            

            Assert.AreEqual(4, numberOfMatches);
        }

        [TestMethod]
        public void TestGetPlayersJoinedATournament()
        {
            var theTournament = tournamentAdmin.GetTournamentList()[0];
            var players = tournamentAdmin.GetPlayersJoinedATournament(theTournament);
            var playerId = players[0].Id;

            Assert.AreEqual("1", playerId);
        }

        [TestMethod]
        public void TestCreateNewTournament()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");
            tournamentAdmin.CreateNewTournament(new Tournament("99", "a", "Badminton", "RoundRobin", "None", "noWhere", DateTime.Now.AddDays(100), DateTime.Now.AddDays(110), 2, 6, staff, LogicLayer.Enums.Status.applicable));
            int nrOfTournaments = tournamentAdmin.GetTournamentList().Count;

            Assert.AreEqual(4, nrOfTournaments);
        }
        [TestMethod]
        public void TestUpdateTournamentStatus()
        {
            var theTournament = tournamentAdmin.GetTournamentList()[1];
            tournamentAdmin.UpdateTournamentStatus(theTournament);
            var status = theTournament.Status;

            Assert.AreEqual(status,LogicLayer.Enums.Status.canceled);
        }
        [TestMethod]
        public void TestAddPlayerToTournament()
        {
            var theTournament = tournamentAdmin.GetTournamentList()[0];
            var player = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            var result = tournamentAdmin.AddPlayerToTournament(theTournament, player);            

            Assert.AreEqual(result,false);
        }

        [TestMethod]
        public void TestDeletePlayerFromTournament()
        {
            var theTournament = tournamentAdmin.GetTournamentList()[0];
            var player = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            var result = tournamentAdmin.DeletePlayerFromTournament(theTournament, player);

            Assert.AreEqual(result, false);
        }
        [TestMethod]
        public void TestGenerateMatches()
        {
            var theTournament = tournamentAdmin.GetTournamentList()[2];            
            var result = tournamentAdmin.GenerateMatches(theTournament);

            Assert.AreEqual(result, false);
        }


        [TestMethod]
        public void TestAddMatchScore()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            var match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);
            tournamentAdmin.AddMatchScore(match, 21, 5);

            Assert.AreEqual(match.Player1Score, 21);
        }
        [TestMethod]
        public void TestTournamentLeaderBoard()
        {
            var tournament = tournamentAdmin.GetTournamentList()[0];
            var match = tournament.Matches[0];

            tournamentAdmin.AddMatchScore(match, 21, 5);

            var list = tournamentAdmin.TournamentLeaderBoard(tournament).ToList();
            var dic = tournamentAdmin.TournamentLeaderBoard(tournament);
            bool t = list[0].Value == 1;

            Assert.AreEqual(t,true);
        }
        [TestMethod]
        public void TestDeleteTournament()
        {
            tournamentAdmin.DeleteTournament(tournamentAdmin.GetTournamentList()[0]);
            int numberOfTournaments = tournamentAdmin.GetTournamentList().Count;
            
            Assert.AreEqual(numberOfTournaments, 2);
        }


    }
}
