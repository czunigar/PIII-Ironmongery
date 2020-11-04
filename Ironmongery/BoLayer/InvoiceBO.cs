using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class InvoiceBO
    {
        ShipmentBO sbo = new ShipmentBO();
        ProductOrderBO prbo = new ProductOrderBO();

        /*Method to search an order on the database*/
        public EInvoice GetOrderById(int id)
        {
            EInvoice invoice = new EInvoice();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                INVOICE o = null;
                if (id > 0)
                {
                    o = db.INVOICES.Find(id);
                }

                invoice.Id = o.Id;
                invoice.LocalDate = o.Local_Date;
                invoice.ShipmentId = o.ShipmentId;
                invoice.Shipment = sbo.GetShipmentById(o.ShipmentId.Value);
                invoice.ProductId = o.ProductId;
                invoice.PrOrder = prbo.GetProdOrderById(o.ProductId.Value);
                invoice.PriceUnit = o.Price_Unit;
                invoice.Total = o.Total;
                invoice.TotalBefTax = o.Total_bef_tax;
                invoice.TotalAftTax = o.Total_aft_tax;
                invoice.Taxes = o.Taxes;
                invoice.Paid = o.Paid;

                return invoice;
            }
        }

        /*Method to add to a list all the orders in the database*/
        public List<EInvoice> LoadOrders(string filter)
        {
            List<EInvoice> invoices = new List<EInvoice>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from o in db.INVOICES.ToList()
                             select new EInvoice
                             {
                                 Id = o.Id,
                                 LocalDate = o.Local_Date,
                                 ShipmentId = o.ShipmentId,
                                 Shipment = sbo.GetShipmentById(o.ShipmentId.Value),
                                 ProductId = o.ProductId,
                                 PrOrder = prbo.GetProdOrderById(o.ProductId.Value),
                                 PriceUnit = o.Price_Unit,
                                 Total = o.Total,
                                 TotalBefTax = o.Total_bef_tax,
                                 TotalAftTax = o.Total_aft_tax,
                                 Taxes = o.Taxes,
                                 Paid = o.Paid
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(p => p.PrOrder.Order.Cid.Equals(filter));
                }
                foreach (var inv in myList)
                {
                    invoices.Add(new EInvoice(inv.Id, inv.LocalDate, inv.ShipmentId, inv.Shipment,
                        inv.ProductId, inv.PrOrder, inv.PriceUnit, inv.Total, inv.TotalBefTax,
                        inv.TotalAftTax, inv.Taxes, inv.Paid));
                }

                return invoices;
            }
        }

        /*Method to save an order in the database*/
        public void Save(EInvoice invo, int pid = 0)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                INVOICE inv = null;
                if (pid == 0)
                {
                    inv = new INVOICE();
                }
                else
                {
                    inv = db.INVOICES.Find(pid);
                }

                inv.Id = invo.Id;
                inv.Local_Date = invo.LocalDate;
                inv.ShipmentId = invo.ShipmentId;                  
                inv.ProductId = invo.ProductId;                          
                inv.Price_Unit = invo.PriceUnit;
                inv.Total = invo.Total;
                inv.Total_bef_tax = invo.TotalBefTax;
                inv.Total_aft_tax = invo.TotalAftTax;
                inv.Taxes = invo.Taxes;
                inv.Paid = invo.Paid;

                if (pid == 0)
                {
                    db.INVOICES.Add(inv);
                }
                else
                {
                    db.Entry(inv).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete an order*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                INVOICE invoice;
                invoice = db.INVOICES.Find(pid);
                db.INVOICES.Remove(invoice);
                db.SaveChanges();
            }
        }
    }
}
