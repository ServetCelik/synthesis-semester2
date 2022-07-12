using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Entities
{
    public class User
    {
        string id;
        string userName;
        string hashedPassword;
        string salt;
        string email;        

        public User(string id, string userName, string hashedPassword, string salt, string email)
        {
            this.id = id;
            this.userName = userName;
            this.hashedPassword = hashedPassword;
            this.salt = salt;
            this.email = email;            
        }

        public string Id { get => id;}
        public string UserName { get => userName; }
        public string HashedPassword { get => hashedPassword;}
        public string Email { get => email;}
        public string Salt { get => salt;}
    }
}
