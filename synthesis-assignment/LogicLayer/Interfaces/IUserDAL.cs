using LogicLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Interfaces
{
    public interface IUserDAL
    {
        public void UserCreator(User user);
        List<User> GetAllUsersDAL();
        public void CreateUserDAL(User user);
        public void DeleteUserDAL(User user);
        public void EditUserDAL(User user);

    }
}
