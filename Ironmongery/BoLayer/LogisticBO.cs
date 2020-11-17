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
        private UserBO ubo;

        /*Method to add all the travels from the database*/
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
                                 Driver = ubo.GetUserById(t.DriverID.Value),
                                 Active = t.Status
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

        /*Method to search a truck on the database*/
        public ELogistic GetTruck(int id)
        {
            ELogistic travel = new ELogistic();
            ubo = new UserBO();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                LOGISTIC lg = null;
                if (id > 0)
                {
                    lg = db.LOGISTICS.Find(id);
                }

                travel.Id = lg.Id;
                travel.VehicleNumber = lg.Vehicle_Number;
                travel.DriverId = lg.DriverID.Value;
                travel.Driver = ubo.GetUserById(lg.DriverID.Value);
                travel.Active = lg.Status;
                
                return travel;
            }
        }

        /*Method to save a truck in the database*/
        public void Save(ELogistic travel)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                LOGISTIC truck = null;
                if (travel.Id == 0)
                {
                    truck = new LOGISTIC();
                }
                else
                {
                    truck = db.LOGISTICS.Find(travel.Id);
                }

                truck.Vehicle_Number = travel.VehicleNumber;
                truck.DriverID = travel.DriverId;
                truck.Status = travel.Active;

                if (travel.Id == 0)
                {
                    db.LOGISTICS.Add(truck);
                }
                else
                {
                    db.Entry(truck).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to truck a product*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                LOGISTIC tr;
                tr = db.LOGISTICS.Find(pid);
                db.LOGISTICS.Remove(tr);
                db.SaveChanges();
            }
        }
    }
}
