using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class ServiceOrderBO
    {
        OrderBO obo;
        ServiceBO sbo;

        /*Method to search a service order in the database*/
        public EServiceOrder GetServOrderById(int id)
        {
            obo = new OrderBO();
            sbo = new ServiceBO();
            EServiceOrder svOrder = new EServiceOrder();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                SERVICE_ORDERS sor = null;
                if (id > 0)
                {
                    sor = db.SERVICE_ORDERS.Find(id);
                }

                svOrder.Id = sor.Id;
                svOrder.OrderID = sor.OrderID;
                svOrder.Order = obo.GetOrderById(sor.OrderID.Value);
                svOrder.ServiceID = sor.ServiceID;
                svOrder.Service = sbo.GetServiceById(sor.ServiceID.Value);

                return svOrder;
            }
        }

        /*Method to add to a list all the service orders in the database*/
        public List<EServiceOrder> LoadServiceOrders(int filter)
        {
            obo = new OrderBO();
            List<EServiceOrder> products = new List<EServiceOrder>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from o in db.SERVICE_ORDERS.ToList()
                             select new EServiceOrder
                             {
                                 Id = o.Id,
                                 OrderID = o.OrderID,
                                 Order = obo.GetOrderById(o.OrderID.Value),
                                 ServiceID = o.ServiceID,
                                 Service = sbo.GetServiceById(o.ServiceID.Value)
            };

                if (filter > 0)
                {
                    myList = myList.Where(p => p.Order.Id == filter);
                }
                foreach (var ord in myList)
                {
                    products.Add(new EServiceOrder(ord.Id, ord.OrderID, ord.ServiceID, ord.Order, ord.Service));
                }

                return products;
            }
        }

        /*Method to save a service order in the database*/
        public void Save(EServiceOrder ord)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                SERVICE_ORDERS orden = null;
                if (ord.Id == 0)
                {
                    orden = new SERVICE_ORDERS();
                }
                else
                {
                    orden = db.SERVICE_ORDERS.Find(ord.Id);
                }

                orden.OrderID = ord.OrderID;
                orden.ServiceID = ord.ServiceID;

                if (ord.Id == 0)
                {
                    db.SERVICE_ORDERS.Add(orden);
                }
                else
                {
                    db.Entry(orden).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete a service order*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                SERVICE_ORDERS orden;
                orden = db.SERVICE_ORDERS.Find(pid);
                db.SERVICE_ORDERS.Remove(orden);
                db.SaveChanges();
            }
        }
    }
}
