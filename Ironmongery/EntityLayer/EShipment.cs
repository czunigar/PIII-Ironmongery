using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EShipment
    {
        public int Id { get; set; }
        public int? SellerID { get; set; }
        public EUser seller;
        public int? ProductOrder { get; set; }
        public EProductOrder pOrder;
        public int? ServiceOrder { get; set; }
        public EServiceOrder sOrder;
        public int? TruckID { get; set; }
        public ELogistic truck;
        public TimeSpan? OrderTime { get; set; }
        public string Status { get; set; }

        public EShipment()
        {
        }

        public EShipment(int id, int? sellerID, EUser seller, int? productOrder, EProductOrder pOrder,
            int? serviceOrder, EServiceOrder sOrder, int? truckID, ELogistic truck, TimeSpan? orderTime, string status)
        {
            Id = id;
            SellerID = sellerID;
            this.seller = seller;
            ProductOrder = productOrder;
            this.pOrder = pOrder;
            ServiceOrder = serviceOrder;
            this.sOrder = sOrder;
            TruckID = truckID;
            this.truck = truck;
            OrderTime = orderTime;
            Status = status;
        }

        public EUser Seller
        {
            get { return this.seller; }
            set { this.seller = value; }
        }
        public EProductOrder POrder
        {
            get { return this.pOrder; }
            set { this.pOrder = value; }
        }
        public EServiceOrder SOrder
        {
            get { return this.sOrder; }
            set { this.sOrder = value; }
        }
        public ELogistic Truck
        {
            get { return this.truck; }
            set { this.truck = value; }
        }
    }
}
