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
    public class UnitTestPlayer
    {
        [TestMethod]
        public void TestConstructor()
        {
            Player player = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);           

            Assert.IsNotNull(player);
        }
        [TestMethod]
        public void TestFirstNameProp()
        {
            Player player = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);           

            Assert.AreEqual(player.FirstName, "Aragorn");
        }
        [TestMethod]
        public void TestLastNameProp()
        {
            Player player = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);

            Assert.AreEqual(player.LastName, "King of Arnor and Gondor");
        }
        [TestMethod]
        public void TestnrOfMatchesWinProp()
        {
            Player player = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);

            Assert.AreEqual(player.NrOfMatchesWin, 1000);
        }
        [TestMethod]
        public void TestnrOfMatchesLostProp()
        {
            Player player = new Player("1", "Ranger of the North", "1234", "5678", "gmail", "Aragorn", "King of Arnor and Gondor", 1000, 0);

            Assert.AreEqual(player.NrOfMatchesLost, 0);
        }
        [TestMethod]
        public void TestWinRate()
        {
            Player gimli = new Player("2", "Dwarf Warrior", "1234", "5678", "gmail", "Gimli", "Battle Axes", 50, 45);

            Assert.AreEqual(gimli.WinRate(), 52.63157894736842);
        }
    }
}
