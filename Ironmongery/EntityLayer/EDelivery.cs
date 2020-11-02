using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EDelivery
    {
        public int Id { get; set; }
        public int? ShipmentID { get; set; }
        public EShipment shipment;
        public string Address { get; set; }
        public string Contact { get; set; }
        public TimeSpan? TimePickup { get; set; }

        public EDelivery()
        {
        }

        public EDelivery(int id, int? shipmentID, EShipment shipment, string address, string contact, TimeSpan? time_Pickup)
        {
            Id = id;
            ShipmentID = shipmentID;
            this.shipment = shipment;
            Address = address;
            Contact = contact;
            TimePickup = time_Pickup;
        }

        public EShipment Shipment
        {
            get { return this.shipment; }
            set { this.shipment = value; }
        }
    }
}
