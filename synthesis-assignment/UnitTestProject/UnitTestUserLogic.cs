using DataAccessLayer.Classes;
using LogicLayer.Entities;
using LogicLayer.Exceptions;
using LogicLayer.Interfaces;
using LogicLayer.LogicClasses;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestUserLogic
    {
        
        private static MockUserDAL dAL = new MockUserDAL();
        private readonly UserAdministrator userAdmin;      

        
        public UnitTestUserLogic()
        {
            userAdmin = new UserAdministrator(dAL);
        }

        [TestMethod]
        public void TestConstructor()
        {
            UserAdministrator userAdministrator = new UserAdministrator(new MockUserDAL());
            Assert.ReferenceEquals(userAdministrator,userAdmin);
        }

        [TestMethod]
        public void TestGetUsers()
        {
            var users = userAdmin.GetUsers();
            Assert.AreEqual(users[0].UserName, "Tom");
        }

        [TestMethod]
        public void TestUpdateUserList()
        {            
            userAdmin.CreateUser(new User("10","jack","1234","1234","abcs"));
            userAdmin.UpdateUserList();
            var userNumber = userAdmin.GetUsers().Count;
            Assert.AreEqual(userNumber, 3);
        }
        [TestMethod]
        public void TestCheckIdExistence()
        {
            User user = new User("10", "jack", "1234", "1234", "abcs");
            bool test = userAdmin.CheckIdExistence(user);
            Assert.AreEqual(test, true);
        }
        [TestMethod]
        public void TestCheckUserNameExistence()
        {
            User user = new User("10", "jack", "1234", "1234", "abcs");
            bool test = userAdmin.CheckUserNameExistence(user);
            Assert.AreNotEqual(test, false);
        }

        [TestMethod]
        public void TestCheckEmailExistence()
        {
            User user = new User("10", "jack", "1234", "1234", "Email");
            bool test = userAdmin.CheckEmailExistence(user);
            Assert.AreEqual(test, true);
        }
        [TestMethod]
        public void TestFindUserById()
        {
            User user = new Player("2", "jack", "555", "666", "noEmail", "Jack", "Blue", 0, 0);
            User test = userAdmin.FindUserById("2");
            Assert.AreEqual(user.UserName, test.UserName);
        }
        [TestMethod]
        public void TestFindUserByUserName()
        {
            User user = new Staff("8", "Stan", "222", "33", "yahoo", "Admin");
            User test = userAdmin.FindUserByUserName("Tom");
            Assert.AreNotEqual(test, user);
        }
        [TestMethod]
        public void TestCreateUser()
        {
            int count1 = userAdmin.GetUsers().Count;
            userAdmin.CreateUser(new Player("4", "jacko", "555", "666", "nmail", "Jack", "Blue", 0, 0));
            int count2 = userAdmin.GetUsers().Count;
            Assert.AreNotEqual(count1, count2);
        }
        [TestMethod]
        public void TestDeleteUser()
        {           
            Player deletedPlayer = new Player("10", "Tom", "1234", "5678", "Email", "Tommy", "Red", 0, 0);
            userAdmin.DeleteUser(deletedPlayer);
            var users = userAdmin.GetUsers();
            Assert.AreNotEqual(users.Count, 2);
        }
        [TestMethod]
        public void TestEditUser()
        {
            Player editedPlayer = new Player("10", "Servet", "1234", "5678", "Email", "Tommy", "Red", 0, 0);
            userAdmin.EditUser(editedPlayer);
            var users = userAdmin.GetUsers();
            Assert.AreNotEqual(users[0].UserName,"Servet");
        }
        [TestMethod]
        public void TestCheckLogin()
        {
            try
            {
                var result = userAdmin.CheckLogin("Tom", "1234");
            }
            catch (Exception e)
            {
                Assert.AreEqual(e.Message, "Failed to authenticate.");
           }
            
            //Assert.ThrowsException<AuthenticationException>(userAdmin.CheckLogin("Tom", "1234")) where 
        }

        [TestMethod]
        public void TestAddAWinToAPlayer()
        {
            Player editedPlayer = new Player("10", "Servet", "1234", "5678", "Email", "Tommy", "Red", 0, 0);
            userAdmin.AddAWinToAPlayer(editedPlayer);
            
            Assert.AreEqual(1, editedPlayer.NrOfMatchesWin);
        }
        [TestMethod]
        public void TestAddALostToAPlayer()
        {
            Player editedPlayer = new Player("10", "Servet", "1234", "5678", "Email", "Tommy", "Red", 0, 0);
            userAdmin.AddALostToAPlayer(editedPlayer);

            Assert.AreEqual(1, editedPlayer.NrOfMatchesLost);
        }
        [TestMethod]
        public void TestCreateHonorListByRate()
        {
            var list = userAdmin.CreateHonorListByRate();
            bool result = list[0].WinRate()>list[list.Count-1].WinRate();

            Assert.AreEqual(true,result);
        }

        [TestMethod]
        public void TestCreateHonorListByTotalWin()
        {
            var list = userAdmin.CreateHonorListByTotalWin();
            bool result = list[0].NrOfMatchesWin > list[list.Count - 1].NrOfMatchesWin;

            Assert.AreEqual(true, result);
        }








        //[TestMethod]
        //public void TestGetMatchesOfATournament()
        //{
        //}
        //[TestMethod]
        //public void TestGetPlayersJoinedATournament()
        //{
        //}
        //[TestMethod]
        //public void TestGetTournamentList()
        //{
        //    Staff staff = new Staff("123", "Jack", "asdf", "asdf", "jack@gmail.com", "Hr");
        //    Tournament tournament = new Tournament("123", "TestTournament", "tennis", "RoundRobin", "None", "Amsterdam", DateTime.Now.AddDays(10), DateTime.Now.AddDays(20), 10, 20, staff, LogicLayer.Enums.Status.applicable);
        //    List<Tournament> tournamentList = new List<Tournament>();
        //    tournamentList.Add(tournament);
        //    mock.Setup(x => x.GetTournamentsFromDBDAL()).Returns(tournamentList);
        //    var tList = mockTAdmin.GetTournamentList();

        //    Assert.AreEqual(tList.Count,1);
        //}
        //[TestMethod]
        //public void TestCreateNewTournament()
        //{
        //    Staff staff = new Staff("123", "Jack", "asdf", "asdf", "jack@gmail.com", "Hr");
        //    Tournament tournament = new Tournament("123", "TestTournament", "tennis", "RoundRobin", "None", "Amsterdam", DateTime.Now.AddDays(10), DateTime.Now.AddDays(20), 10, 20, staff, LogicLayer.Enums.Status.applicable);
        //    List<Tournament> tournamentList = new List<Tournament>();
        //    tournamentList.Add(tournament);





        //    mock.Setup(x => x.GetTournamentsFromDBDAL()).Returns(tournamentList);
        //    mock.Setup(x => x.GetPlayersJoinedATournamentDAL(tournament)).Returns(new List<Player>());
        //    mock.Setup(x => x.FindMatchesByTournamentIdDAL(tournament)).Returns(()=>null);
        //    mockTAdmin.UpdateTournamentList();
        //    var tlist = mockTAdmin.GetTournamentList();

        //    Assert.AreEqual(tlist.Count, 1);
        //}
    }
}