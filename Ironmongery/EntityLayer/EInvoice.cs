using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EInvoice
    {
        public int Id { get; set; }
        public DateTime? LocalDate { get; set; }
        public int? ShipmentId { get; set; }
        public EShipment shipment;
        public int? ProductId { get; set; }
        public EProductOrder prOrder;
        public decimal? PriceUnit { get; set; }
        public decimal? Total { get; set; }
        public decimal? TotalBefTax { get; set; }
        public decimal? TotalAftTax { get; set; }
        public decimal? Taxes { get; set; }
        public bool? Paid { get; set; }

        public EInvoice()
        {
        }

        public EInvoice(int id, DateTime? local_Date, int? shipmentId, EShipment shipment,
            int? productId, EProductOrder prOrder, decimal? price_Unit, decimal? total,
            decimal? total_bef_tax, decimal? total_aft_tax, decimal? taxes, bool? paid)
        {
            Id = id;
            LocalDate = local_Date;
            ShipmentId = shipmentId;
            this.shipment = shipment;
            ProductId = productId;
            this.prOrder = prOrder;
            PriceUnit = price_Unit;
            Total = total;
            TotalBefTax = total_bef_tax;
            TotalAftTax = total_aft_tax;
            Taxes = taxes;
            Paid = paid;
        }

        public EShipment Shipment
        {
            get { return this.shipment; }
            set { this.shipment = value; }
        }

        public EProductOrder PrOrder
        {
            get { return this.prOrder; }
            set { this.prOrder = value; }
        }
    }
}
