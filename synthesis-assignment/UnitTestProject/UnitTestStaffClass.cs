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
    public class UnitTestStaffClass
    {
        [TestMethod]
        public void TestConstructor()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");

            Assert.IsNotNull(staff);
        }
        [TestMethod]
        public void TestRoleProp()
        {
            Staff staff = new Staff("1", "Eddy", "1234", "5678", "hotmail", "Admin");

            Assert.AreEqual(staff.Role, "Admin");
        }
    }
}
