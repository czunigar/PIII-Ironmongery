using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class ShipmentBO
    {
        ProductOrderBO pobo;
        ServiceOrderBO sorbo;
        UserBO ubo;
        LogisticBO lbo;

        /*Method to search a shipment in the database*/
        public EShipment GetShipmentById(int id)
        {
            pobo = new ProductOrderBO();
            sorbo = new ServiceOrderBO();
            ubo = new UserBO();
            lbo = new LogisticBO();
            EShipment shipment = new EShipment();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                SHIPMENT ship = null;
                if (id > 0)
                {
                    ship = db.SHIPMENTS.Find(id);
                }

                shipment.Id = ship.Id;
                shipment.SellerID = ship.SellerID;
                shipment.Seller = ubo.GetUserById(ship.SellerID.Value);
                shipment.ProductOrder = ship.Product_Order;
                shipment.POrder = pobo.GetProdOrderById(ship.Product_Order.Value);
                shipment.ServiceOrder = ship.Service_Order;
                shipment.SOrder = sorbo.GetServOrderById(ship.Service_Order.Value);
                shipment.TruckID = ship.TruckID;
                shipment.Truck = lbo.GetTruck(ship.TruckID.Value);
                shipment.OrderTime = ship.Order_Time;
                shipment.Status = ship.Status;

                return shipment;
            }
        }

        /*Method to add to a list all the shipments in the database*/
        public List<EShipment> LoadShipments(string filter)
        {
            pobo = new ProductOrderBO();
            sorbo = new ServiceOrderBO();
            ubo = new UserBO();
            lbo = new LogisticBO();
            List<EShipment> shipments = new List<EShipment>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from o in db.SHIPMENTS.ToList()
                             select new EShipment
                             {
                                 Id = o.Id,
                                 SellerID = o.SellerID,
                                 Seller = ubo.GetUserById(o.SellerID.Value),
                                 ProductOrder = o.Product_Order,
                                 POrder = pobo.GetProdOrderById(o.Product_Order.Value),
                                 ServiceOrder = o.Service_Order,
                                 SOrder = sorbo.GetServOrderById(o.Service_Order.Value),
                                 TruckID = o.TruckID,
                                 Truck = lbo.GetTruck(o.TruckID.Value),
                                 OrderTime = o.Order_Time,
                                 Status = o.Status
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(p => p.Seller.Code.Equals(filter));
                }
                foreach (var sp in myList)
                {
                    shipments.Add(new EShipment(sp.Id, sp.SellerID, sp.Seller, sp.ProductOrder,
                        sp.POrder, sp.ServiceOrder, sp.SOrder, sp.TruckID, sp.Truck,
                        sp.OrderTime, sp.Status));
                }

                return shipments;
            }
        }

        /*Method to save a shipment in the database*/
        public void Save(EShipment shipment, int pid = 0)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                SHIPMENT ship = null;
                if (pid == 0)
                {
                    ship = new SHIPMENT();
                }
                else
                {
                    ship = db.SHIPMENTS.Find(pid);
                }

                ship.Id = shipment.Id;
                ship.SellerID = shipment.SellerID;
                ship.Product_Order = shipment.ProductOrder;
                ship.Service_Order = shipment.ServiceOrder;
                ship.TruckID = shipment.TruckID;
                ship.Order_Time = shipment.OrderTime;
                ship.Status = shipment.Status;

                if (pid == 0)
                {
                    db.SHIPMENTS.Add(ship);
                }
                else
                {
                    db.Entry(ship).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete a shipment*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                SHIPMENT shipm;
                shipm = db.SHIPMENTS.Find(pid);
                db.SHIPMENTS.Remove(shipm);
                db.SaveChanges();
            }
        }
    }
}
