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
        /*Method to search a user on the database*/
        public EUser GetUserById(int id)
        {
            EUser user = new EUser();
            using(IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                USER u = null;
                if (id > 0)
                {
                    u = db.USERS.Find(id);
                }

                user.Id = u.Id;
                user.Code = u.Code;
                user.Username = u.Username;
                user.Password = u.Password;
                user.Type = u.Type;
                user.Admin = u.Admin;                

                return user;
            }
        }

        /*Method to add to a list all the users in the database*/
        public List<EUser> LoadUsers(string filter)
        {
            List<EUser> users = new List<EUser>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from u in db.USERS.ToList()
                             select new EUser
                             {
                                 Id = u.Id,
                                 Code = u.Code,
                                 Username = u.Username,
                                 Password = u.Password,
                                 Type = u.Type,
                                 Admin = u.Admin
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(u => u.Code.Equals(filter));
                }

                foreach (var usr in users)
                {
                    users.Add(new EUser(usr.Id, usr.Code, usr.Username, usr.Password,
                        usr.Type, usr.Admin));
                }

                return users;
            }
        }

        /*Method to add to a list all the users in the database*/
        public EUser SignIn(string username, string password)
        {
            EUser usr = new EUser();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var logged = from u in db.USERS.ToList()
                             select new EUser
                             {
                                 Id = u.Id,
                                 Code = u.Code,
                                 Username = u.Username,
                                 Password = u.Password,
                                 Type = u.Type,
                                 Admin = u.Admin
                             };

                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    logged = logged.Where(u => u.Code.Equals(username) && u.Password.Equals(password));
                }

                foreach (var user in logged)
                {
                    usr = new EUser(user.Id, user.Code, user.Username, user.Password,
                        user.Type, user.Admin);
                }
                return usr;
            }
        }

        /*Method to save a user in the database*/
        public void Save(EUser user, int pid = 0)
        {
            using(IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                USER newUser = null;
                if (pid == 0)
                {
                    newUser = new USER();
                }
                else
                {
                    newUser = db.USERS.Find(pid);
                }
                newUser.Code = user.Code;
                newUser.Username = user.Username;
                newUser.Password = user.Password;
                newUser.Type = user.Type;
                newUser.Admin = user.Admin;

                if (pid == 0)
                {
                    db.USERS.Add(newUser);
                }
                else
                {
                    db.Entry(newUser).State = System.Data.Entity.EntityState.Modified;
                }
                
                db.SaveChanges();
            }
        }

        /*Method to delete a user*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                USER user;
                user = db.USERS.Find(pid);
                db.USERS.Remove(user);
                db.SaveChanges();
            }
        }
    }
}
