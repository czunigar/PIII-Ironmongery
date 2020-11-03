using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class OrderBO
    {
        /*Method to search an order on the database*/
        public EOrder GetOrderById(int id)
        {
            EOrder order = new EOrder();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                ORDER o = null;
                if (id > 0)
                {
                    o = db.ORDERS.Find(id);
                }

                order.Id = o.Id;
                order.Cid = o.Cid;
                order.ClientName = o.Client_Name;
                order.Date = o.Date;
                order.Status = o.Status;

                return order;
            }
        }

        /*Method to add to a list all the orders in the database*/
        public List<EOrder> LoadOrders(string filter)
        {
            List<EOrder> products = new List<EOrder>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from o in db.ORDERS.ToList()
                             select new EOrder
                             {
                                 Id = o.Id,
                                 Cid = o.Cid,
                                 ClientName = o.Client_Name,
                                 Date = o.Date,
                                 Status = o.Status
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(p => p.Cid.Equals(filter));
                }
                foreach (var ord in myList)
                {
                    products.Add(new EOrder(ord.Id, ord.Cid, ord.ClientName, ord.Date,
                        ord.Status));
                }

                return products;
            }
        }

        /*Method to save an order in the database*/
        public void Save(EOrder ord, int pid = 0)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                ORDER orden = null;
                if (pid == 0)
                {
                    orden = new ORDER();
                }
                else
                {
                    orden = db.ORDERS.Find(pid);
                }

                orden.Id = ord.Id;
                orden.Cid = ord.Cid;
                orden.Client_Name = ord.ClientName;
                orden.Date = ord.Date;
                orden.Status = ord.Status;

                if (pid == 0)
                {
                    db.ORDERS.Add(orden);
                }
                else
                {
                    db.Entry(orden).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete an order*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                ORDER orden;
                orden = db.ORDERS.Find(pid);
                db.ORDERS.Remove(orden);
                db.SaveChanges();
            }
        }
    }
}
