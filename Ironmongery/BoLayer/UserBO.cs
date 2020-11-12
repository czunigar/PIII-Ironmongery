using DataLayer;
using EntityLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using ServiceLayer;

namespace BoLayer
{
    public class UserBO
    {
        Messages messages = new Messages();

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
                user.Cid = u.Cid;
                user.Name = u.Username;
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
                                 Cid = u.Cid,
                                 Name = u.Username,
                                 Code = u.Code,
                                 Password = u.Password,
                                 Type = u.Type,
                                 Admin = u.Admin
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(u => u.Code.Equals(filter));
                }

                foreach (var usr in myList)
                {
                    users.Add(new EUser(usr.Id, usr.Cid, usr.Name, usr.Code, usr.Password,
                        usr.Type, usr.Admin));
                }

                return users;
            }
        }

        /*Method to add to a list all the users in the database*/
        public EUser SignIn(EUser ur)
        {
            EUser usr = new EUser();


            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var logged = from u in db.USERS.ToList()
                             select new EUser
                             {
                                 Id = u.Id,
                                 Cid = u.Cid,
                                 Name = u.Username,
                                 Code = u.Code,
                                 Password = u.Password,
                                 Type = u.Type,
                                 Admin = u.Admin
                             };

                if (!string.IsNullOrEmpty(ur.Code) && !string.IsNullOrEmpty(ur.Password))
                {
                    logged = logged.Where(u => u.Code.Equals(ur.Code) && u.Password.Equals(ur.Password));
                }

                foreach (var user in logged)
                {
                    usr = new EUser(usr.Id, usr.Cid, usr.Name, usr.Code, usr.Password,
                        usr.Type, usr.Admin);
                    return usr;
                }
            }
            return null;
        }

        public EUser Login(EUser user)
        {
            if (string.IsNullOrEmpty(user.Code))
            {
                messages.notification("Please enter your username");
            }
            if (string.IsNullOrEmpty(user.Password))
            {
                messages.notification("Please enter a password");
            }
            if (user.Password.Length < 12)
            {
                messages.notification("Password most have more than 12 characters");
            }
            user.Password = GetMD5(user.Password);

            return SignIn(user);
        }


        /*Method to encryp a text*/
        public string GetMD5(string text)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] result = md5.Hash;
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                str.Append(result[i].ToString("x2"));
            }
          
            return str.ToString();
        }

        /*Method to save a user in the database*/
        public void Save(EUser user)
        {
            using(IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                USER newUser = null;
                if (user.Id == 0)
                {
                    newUser = new USER();
                }
                else
                {
                    newUser = db.USERS.Find(user.Id);
                }
                newUser.Code = user.Code;
                newUser.Cid = user.Cid;
                newUser.Username = user.Name;
                newUser.Password = user.Password;
                newUser.Type = user.Type;
                newUser.Admin = user.Admin;

                if (user.Id == 0)
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
