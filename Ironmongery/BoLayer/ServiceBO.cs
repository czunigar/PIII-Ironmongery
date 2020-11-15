using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataLayer;

namespace BoLayer
{
    public class ServiceBO
    {
        /*Method to add to a list all the services in the database*/
        public List<EService> loadServices(string filter)
        {
            List<EService> services = new List<EService>();
            using(IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from s in db.SERVICES.ToList()
                             select new EService
                             {
                                 Id = s.Id,
                                 Name = s.Service_Name,
                                 Category = s.Category,
                                 Description = s.Service_Description,
                                 Price = s.Price
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(s => s.Name.Equals(filter));
                }

                foreach (var serv in myList)
                {
                    services.Add(new EService(serv.Id, serv.Name, serv.Category,
                        serv.Description, serv.Price));
                }
                return services;
            }
        }

        /*Method to search a service on the database*/
        public EService GetServiceById(int id)
        {
            EService service = new EService();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                SERVICE nt = null;
                if (id > 0)
                {
                    nt = db.SERVICES.Find(id);
                }

                service.Id = nt.Id;
                service.Name = nt.Service_Name;
                service.Category = nt.Category;
                service.Description = nt.Service_Description;
                service.Price = nt.Price;

                return service;
            }
        }

        /*Method to save a service in the database*/
        public void Save(EService service)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                SERVICE serv = null;
                if (service.Id == 0)
                {
                    serv = new SERVICE();
                }
                else
                {
                    serv = db.SERVICES.Find(service.Id);
                }

                serv.Service_Name = service.Name;
                serv.Category = service.Category;
                serv.Service_Description = service.Description;
                serv.Price = service.Price;

                if (service.Id == 0)
                {
                    db.SERVICES.Add(serv);
                }
                else
                {
                    db.Entry(serv).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete a service*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                SERVICE serv;
                serv = db.SERVICES.Find(pid);
                db.SERVICES.Remove(serv);
                db.SaveChanges();
            }
        }
    }
}
