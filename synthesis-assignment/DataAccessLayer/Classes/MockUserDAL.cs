using LogicLayer.Entities;
using LogicLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Classes
{
    public class MockUserDAL :IUserDAL
    {
        public void UserCreator(User user)
        {

        }
        public List<User> GetAllUsersDAL()
        {
            Player p1 = new Player("10", "Tom", "1234", "5678", "Email", "Tommy", "Red", 5, 1);
            Player p2 = new Player("2", "jack", "555", "666", "noEmail", "Jack", "Blue", 10, 9);
            Player p3 = new Player("7", "Inna", "444", "777", "gmail", "Anna", "Black", 4, 3);
            Staff s1 = new Staff("8", "Stan", "222", "33", "yahoo", "Admin");
            List<User> users = new List<User>() { p1,p2,s1 };
            return users;
        }
        public void CreateUserDAL(User user)
        {

        }
        public void DeleteUserDAL(User user)
        {

        }
        public void EditUserDAL(User user)
        {

        }
    }
}
