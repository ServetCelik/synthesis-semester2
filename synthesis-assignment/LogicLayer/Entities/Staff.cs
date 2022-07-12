using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.Entities
{
    public class Staff : User
    {
        string role;
        public Staff(string id, string userName, string hashedPassword, string salt, string email, string role) : base(id, userName, hashedPassword, salt, email)
        {
            this.role = role;
        }       

        public string Role { get => role;}
    }
}
