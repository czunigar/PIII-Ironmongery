using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class UserBO
    {
        public EUser getUserById(int id)
        {
            EUser user = new EUser();
            using(IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var users = from u in db.USERS
                           select new EUser
                           {
                               Id = u.Id,
                               Code = u.Code,
                               Username = u.Username,
                               Password = u.Password,
                               Type = u.Type,
                               Admin = u.Admin                        
                           };
                foreach (var u in users)
                {
                    if (u.Id == id)
                    {
                        user = u;
                    }
                }
                return user;
            }
        }
    }
}
