using LogicLayer.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestMatchClass
    {
        [TestMethod]
        public void TestConstructor()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);            
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);

            Assert.IsNotNull(match);
        }
        [TestMethod]
        public void TestMatchIdProp()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);

            Assert.AreEqual(match.MatchId, "1");
        }
        [TestMethod]
        public void TestTournamentIdProp()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);

            Assert.AreEqual(match.TournamentId, "1");
        }
        [TestMethod]
        public void TestDateProp()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);

            Assert.AreEqual(match.Date.Date, DateTime.Now.AddDays(105).Date);
        }
        [TestMethod]
        public void TestPlayer1Prop()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);

            Assert.AreEqual(match.Player1, player1);
        }
        [TestMethod]
        public void TestPlayer2Prop()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);

            Assert.AreEqual(match.Player2, player2);
        }
        [TestMethod]
        public void TestPlayer1ScoreProp()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);

            Assert.AreEqual(match.Player1Score, null);
        }
        [TestMethod]
        public void TestPlayer2ScoreProp()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);
            match.AddScore(3, 21);

            Assert.AreEqual(match.Player2Score, 21);
        }
        [TestMethod]
        public void TestSportTypeProp()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);

            Assert.AreEqual(match.SportType, "Badminton");
        }
        [TestMethod]
        public void TestShowScores()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);
            string result = match.ShowScores();
            Assert.AreEqual(result, "-/-");
        }
        [TestMethod]
        public void TestAddScore()
        {
            Player player1 = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);
            Player player2 = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);
            Match match = new Match("1", "1", DateTime.Now.AddDays(105), "Badminton", player1, player2);

            Assert.AreEqual(match.AddScore(21,22), false);
        }

    }
}
