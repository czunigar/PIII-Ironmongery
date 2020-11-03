using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ENotice
    {
        public int Id { get; set; }
        public int? ShipmentID { get; set; }
        public EShipment shipment;
        public TimeSpan? LocalTime { get; set; }
        public int? ProductId { get; set; }
        public EProductOrder prdOrder;

        public ENotice()
        {
        }

        public ENotice(int id, int? shipmentID, EShipment shipment, TimeSpan? local_Time, int? productId, EProductOrder prdOrder)
        {
            Id = id;
            ShipmentID = shipmentID;
            this.shipment = shipment;
            LocalTime = local_Time;
            ProductId = productId;
            this.prdOrder = prdOrder;
        }

        public EShipment Shipment
        {
            get { return this.shipment; }
            set { this.shipment = value; }
        }

        public EProductOrder PrdOrder
        {
            get { return this.prdOrder; }
            set { this.prdOrder = value; }
        }
    }
}
