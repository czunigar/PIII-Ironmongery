using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class ProductOrderBO
    {
        OrderBO obo;

        /*Method to search a product order in the database*/
        public EProductOrder GetProdOrderById(int id)
        {
            obo = new OrderBO();
            EProductOrder pdOrder = new EProductOrder();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var orders = from o in db.PRODUCT_ORDERS.ToList()
                             select new EProductOrder
                             {
                                 Id = o.Id,
                                 OrderID = o.OrderID,
                                 Order = obo.GetOrderById(o.OrderID.Value),
                                 ProductID = o.ProductID,
                                 Units = o.Units
                             };

                orders = orders.Where(o => o.Id == id);

                foreach (var ord in orders)
                {
                    pdOrder = new EProductOrder(ord.Id, ord.OrderID, ord.Order, ord.ProductID,
                        ord.Units);
                }

                return pdOrder;
            }
        }

        /*Method to add to a list all the product orders in the database*/
        public List<EProductOrder> LoadProductOrders(string filter)
        {
            obo = new OrderBO();
            List<EProductOrder> products = new List<EProductOrder>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from o in db.PRODUCT_ORDERS.ToList()
                             select new EProductOrder
                             {
                                 Id = o.Id,
                                 OrderID = o.OrderID,
                                 Order = obo.GetOrderById(o.OrderID.Value),
                                 ProductID = o.ProductID,
                                 Units = o.Units
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(p => p.Order.Cid.Equals(filter));
                }
                foreach (var ord in myList)
                {
                    products.Add(new EProductOrder(ord.Id, ord.OrderID, ord.Order, ord.ProductID,
                        ord.Units));
                }

                return products;
            }
        }

        /*Method to save a product order in the database*/
        public void Save(EProductOrder ord, int pid = 0)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                PRODUCT_ORDERS orden = null;
                if (pid == 0)
                {
                    orden = new PRODUCT_ORDERS();
                }
                else
                {
                    orden = db.PRODUCT_ORDERS.Find(pid);
                }

                orden.Id = ord.Id;
                orden.OrderID = ord.OrderID;
                orden.ProductID = ord.ProductID;
                orden.Units = ord.Units;

                if (pid == 0)
                {
                    db.PRODUCT_ORDERS.Add(orden);
                }
                else
                {
                    db.Entry(orden).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete a product order*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                PRODUCT_ORDERS orden;
                orden = db.PRODUCT_ORDERS.Find(pid);
                db.PRODUCT_ORDERS.Remove(orden);
                db.SaveChanges();
            }
        }
    }
}
