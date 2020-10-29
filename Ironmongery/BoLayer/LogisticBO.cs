using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BoLayer
{
    public class LogisticBO
    {
        /*Method to add all the travels from the database*/
        private UserBO ubo;
        public List<ELogistic> loadTravels(string filter)
        {
            List<ELogistic> travels = new List<ELogistic>();
            ubo = new UserBO();
            using(IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from t in db.LOGISTICS.ToList()
                             select new ELogistic
                             {
                                 Id = t.Id,
                                 VehicleNumber = t.Vehicle_Number,
                                 DriverId = t.DriverID.Value,
                                 Driver = ubo.getUserById(t.DriverID.Value),
                                 Active = t.Active
                             };
                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(t => t.VehicleNumber.Equals(filter));
                }

                foreach (var trav in myList)
                {
                    travels.Add(new ELogistic(trav.Id, trav.VehicleNumber, trav.DriverId,
                        trav.Driver, trav.Active));
                }

                return travels;
            }
        }
    }
}
