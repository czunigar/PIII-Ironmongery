using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class TruckBO
    {
        LogisticBO lbo = new LogisticBO();
        ProductOrderBO prbo = new ProductOrderBO();

        /*Method to search a truck on the database*/
        public ETruck GetOrderById(int id)
        {
            ETruck truck = new ETruck();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                TRUCK tr = null;
                if (id > 0)
                {
                    tr = db.TRUCKs.Find(id);
                }

                truck.Id = tr.Id;
                truck.Code = tr.Code;
                truck.Name = tr.Name;
                truck.TruckID = tr.TruckID;
                truck.Truck = lbo.GetTruck(tr.TruckID.Value);
                truck.OrderId = tr.OrderId;
                truck.PrOrder = prbo.GetProdOrderById(tr.OrderId.Value);
                truck.Observations = tr.Observations;

                return truck;
            }
        }

        /*Method to add to a list all the trucks in the database*/
        public List<ETruck> LoadOrders(string filter)
        {
            List<ETruck> trucks = new List<ETruck>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from tr in db.TRUCKs.ToList()
                             select new ETruck
                             {
                                 Id = tr.Id,
                                 Code = tr.Code,
                                 Name = tr.Name,
                                 TruckID = tr.TruckID,
                                 Truck = lbo.GetTruck(tr.TruckID.Value),
                                 OrderId = tr.OrderId,
                                 PrOrder = prbo.GetProdOrderById(tr.OrderId.Value),
                                 Observations = tr.Observations
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(p => p.Code.Equals(filter));
                }
                foreach (var tru in myList)
                {
                    trucks.Add(new ETruck(tru.Id, tru.Code, tru.Name, tru.TruckID,
                        tru.Truck, tru.OrderId, tru.PrOrder, tru.Observations));
                }

                return trucks;
            }
        }

        /*Method to save a truck in the database*/
        public void Save(ETruck tr)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                TRUCK truck = null;
                if (tr.Id == 0)
                {
                    truck = new TRUCK();
                }
                else
                {
                    truck = db.TRUCKs.Find(tr.Id);
                }

                truck.Code = tr.Code;
                truck.Name = tr.Name;
                truck.TruckID = tr.TruckID;
                truck.OrderId = tr.OrderId;
                truck.Observations = tr.Observations;

                if (tr.Id == 0)
                {
                    db.TRUCKs.Add(truck);
                }
                else
                {
                    db.Entry(truck).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete a truck*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                TRUCK truck;
                truck = db.TRUCKs.Find(pid);
                db.TRUCKs.Remove(truck);
                db.SaveChanges();
            }
        }
    }
}
