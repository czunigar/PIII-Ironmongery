using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class NoticeBO
    {
        ShipmentBO smbo = new ShipmentBO();
        ProductOrderBO prbo = new ProductOrderBO();

        /*Method to search a notice in the database*/
        public ENotice GetDeliveryById(int id)
        {

            ENotice notice = new ENotice();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                NOTICE nt = null;
                if(id > 0)
                {
                    nt = db.NOTICES.Find(id);
                }

                notice.Id = nt.Id;
                notice.ShipmentID = nt.ShipmentID;
                notice.Shipment = smbo.GetShipmentById(nt.ShipmentID.Value);
                notice.LocalTime = nt.Local_Time;
                notice.ProductId = nt.ProductId;
                notice.PrdOrder = prbo.GetProdOrderById(nt.ProductId.Value);

                return notice;
            }
        }

        /*Method to add to a list all the notices in the database*/
        public List<ENotice> LoadDeliveries(string filter)
        {

            List<ENotice> notices = new List<ENotice>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from o in db.NOTICES.ToList()
                             select new ENotice
                             {
                                 Id = o.Id,
                                 ShipmentID = o.ShipmentID,
                                 Shipment = smbo.GetShipmentById(o.ShipmentID.Value),
                                 LocalTime = o.Local_Time,
                                 ProductId = o.ProductId,
                                 PrdOrder = prbo.GetProdOrderById(o.ProductId.Value)
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(p => p.Shipment.Seller.Code.Equals(filter));
                }
                foreach (var nt in myList)
                {
                    notices.Add(new ENotice(nt.Id, nt.ShipmentID, nt.Shipment, nt.LocalTime,
                        nt.ProductId, nt.PrdOrder));
                }

                return notices;
            }
        }

        /*Method to save a notice in the database*/
        public void Save(ENotice note, int pid = 0)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                NOTICE nt = null;
                if (pid == 0)
                {
                    nt = new NOTICE();
                }
                else
                {
                    nt = db.NOTICES.Find(pid);
                }

                nt.Id = note.Id;
                nt.ShipmentID = note.ShipmentID;
                nt.Local_Time = note.LocalTime;
                nt.ProductId = note.ProductId;


                if (pid == 0)
                {
                    db.NOTICES.Add(nt);
                }
                else
                {
                    db.Entry(nt).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete a notice*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                NOTICE not;
                not = db.NOTICES.Find(pid);
                db.NOTICES.Remove(not);
                db.SaveChanges();
            }
        }
    }
}
