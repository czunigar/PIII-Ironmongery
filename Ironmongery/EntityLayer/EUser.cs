using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EUser
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public bool Admin { get; set; }

        public EUser()
        {
        }

        public EUser(int id, string code, string username, string password, string type, bool admin)
        {
            Id = id;
            Code = code;
            Username = username;
            Password = password;
            Type = type;
            Admin = admin;
        }

        public override string ToString()
        {
            return $"{Code} - {Username}";
        }
    }
}
