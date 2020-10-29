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
                                 ServiceName = s.Service_Name,
                                 Category = s.Category,
                                 ServiceDescription = s.Service_Description,
                                 Price = s.Price
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(s => s.ServiceName.Equals(filter));
                }

                foreach (var serv in myList)
                {
                    services.Add(new EService(serv.Id, serv.ServiceName, serv.Category,
                        serv.ServiceDescription, serv.Price));
                }
                return services;
            }
        } 
    }
}
