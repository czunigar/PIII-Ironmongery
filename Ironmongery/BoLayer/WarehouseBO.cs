using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class WarehouseBO
    {
        LogisticBO lbo = new LogisticBO();
        /*Method to search a stock on the database*/
        public EWarehouse GetOrderById(int id)
        {
            EWarehouse ware = new EWarehouse();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                WAREHOUSE o = null;
                if (id > 0)
                {
                    o = db.WAREHOUSEs.Find(id);
                }

                ware.Id = o.Id;
                ware.EntryTime = o.EntryTime;
                ware.TruckId = o.TruckId;
                ware.Truck = lbo.GetTruck(o.TruckId.Value);
                ware.ExitTime = o.ExitTime;

                return ware;
            }
        }

        /*Method to add to a list all the stocks in the database*/
        public List<EWarehouse> LoadOrders(string filter)
        {
            List<EWarehouse> products = new List<EWarehouse>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from o in db.WAREHOUSEs.ToList()
                             select new EWarehouse
                             {
                                 Id = o.Id,
                                 EntryTime = o.EntryTime,
                                 TruckId = o.TruckId,
                                 Truck = lbo.GetTruck(o.TruckId.Value),
                                 ExitTime = o.ExitTime
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(p => p.Truck.Driver.Code.Equals(filter));
                }
                foreach (var war in myList)
                {
                    products.Add(new EWarehouse(war.Id, war.EntryTime, war.TruckId, war.Truck,
                        war.ExitTime));
                }

                return products;
            }
        }

        /*Method to save a stock in the database*/
        public void Save(EWarehouse store)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                WAREHOUSE ware = null;
                if (store.Id == 0)
                {
                    ware = new WAREHOUSE();
                }
                else
                {
                    ware = db.WAREHOUSEs.Find(store.Id);
                }

                ware.EntryTime = store.EntryTime;
                ware.TruckId = store.TruckId;
                ware.ExitTime = store.ExitTime;

                if (store.Id == 0)
                {
                    db.WAREHOUSEs.Add(ware);
                }
                else
                {
                    db.Entry(ware).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete a stock*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                WAREHOUSE wareh;
                wareh = db.WAREHOUSEs.Find(pid);
                db.WAREHOUSEs.Remove(wareh);
                db.SaveChanges();
            }
        }
    }
}
