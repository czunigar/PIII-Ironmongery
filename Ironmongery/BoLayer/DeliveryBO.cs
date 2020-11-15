using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class DeliveryBO
    {
        ShipmentBO smbo = new ShipmentBO();

        /*Method to search a delivery in the database*/
        public EDelivery GetDeliveryById(int id)
        {

            EDelivery delivery = new EDelivery();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                DELIVERY dl = null;
                if (id > 0)
                {
                    dl = db.DELIVERies.Find(id);
                }

                delivery.Id = dl.Id;
                delivery.ShipmentID = dl.ShipmentID;
                delivery.Shipment = smbo.GetShipmentById(dl.ShipmentID.Value);
                delivery.Address = dl.Address;
                delivery.Contact = dl.Contact;
                delivery.TimePickup = dl.Time_Pickup;

                return delivery;
            }
        }

        /*Method to add to a list all the deliveries in the database*/
        public List<EDelivery> LoadDeliveries(string filter)
        {

            List<EDelivery> deliveries = new List<EDelivery>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from o in db.DELIVERies.ToList()
                             select new EDelivery
                             {
                                 Id = o.Id,
                                 ShipmentID = o.ShipmentID,
                                 Shipment = smbo.GetShipmentById(o.ShipmentID.Value),
                                 Address = o.Address,
                                 Contact = o.Contact,
                                 TimePickup = o.Time_Pickup
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(p => p.Shipment.Seller.Code.Equals(filter));
                }
                foreach (var dl in myList)
                {
                    deliveries.Add(new EDelivery(dl.Id, dl.ShipmentID, dl.Shipment, dl.Address,
                        dl.Contact, dl.TimePickup));
                }

                return deliveries;
            }
        }

        /*Method to save a delivery in the database*/
        public void Save(EDelivery delivery)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                DELIVERY delv = null;
                if (delivery.Id == 0)
                {
                    delv = new DELIVERY();
                }
                else
                {
                    delv = db.DELIVERies.Find(delivery.Id);
                }

                delv.ShipmentID = delivery.ShipmentID;
                delv.Address = delivery.Address;
                delv.Contact = delivery.Contact;
                delv.Time_Pickup = delivery.TimePickup;


                if (delivery.Id == 0)
                {
                    db.DELIVERies.Add(delv);
                }
                else
                {
                    db.Entry(delv).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete a delivery*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                DELIVERY del;
                del = db.DELIVERies.Find(pid);
                db.DELIVERies.Remove(del);
                db.SaveChanges();
            }
        }
    }
}
