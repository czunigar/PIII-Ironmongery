using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EUser : EPerson
    {
        public string Code { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public bool? Admin { get; set; }

        public EUser()
        {
        }

        public EUser(int id, string cid, string name, string code, string password, string type, bool? admin) 
            : base(id, cid, name)
        {
            Id = id;
            Cid = cid;
            Person_Name = name;
            Code = code;
            Password = password;
            Type = type;
            Admin = admin;
        }

        public override string ToString()
        {
            return $"{Code} - {Person_Name}";
        }
    }
}
