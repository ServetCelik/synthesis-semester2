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
    public class UnitTestUserClass
    {
        [TestMethod]
        public void TestConstructor()
        {
            User jack = new User("1", "realjack", "1234", "5678", "gmail");

            Assert.IsNotNull(jack);
        }
        [TestMethod]
        public void TestIdProp()
        {
            User jack = new User("1", "realjack", "1234", "5678", "gmail");

            Assert.AreEqual(jack.Id, "1");
        }
        [TestMethod]
        public void TestUserNameProp()
        {
            User jack = new User("1", "realjack", "1234", "5678", "gmail");

            Assert.AreEqual(jack.UserName, "realjack");
        }
        [TestMethod]
        public void TestHashedPasswordProp()
        {
            User jack = new User("1", "realjack", "1234", "5678", "gmail");

            Assert.AreEqual(jack.HashedPassword, "1234");
        }
        [TestMethod]
        public void TestSaltProp()
        {
            User jack = new User("1", "realjack", "1234", "5678", "gmail");

            Assert.AreEqual(jack.Salt, "5678");
        }
        [TestMethod]
        public void TestEmailProp()
        {
            User jack = new User("1", "realjack", "1234", "5678", "gmail");

            Assert.AreEqual(jack.Email, "gmail");
        }
    }
}
