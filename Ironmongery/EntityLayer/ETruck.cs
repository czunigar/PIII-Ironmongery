using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ETruck
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? TruckID { get; set; }
        public ELogistic truck;
        public int? OrderId { get; set; }
        public EProductOrder prOrder;
        public string Observations { get; set; }

        public ETruck()
        {
        }

        public ETruck(int id, string code, string name, int? truckID, ELogistic truck,
            int? orderId, EProductOrder prOrder, string observations)
        {
            Id = id;
            Code = code;
            Name = name;
            TruckID = truckID;
            this.truck = truck;
            OrderId = orderId;
            this.prOrder = prOrder;
            Observations = observations;
        }

        public ELogistic Truck
        {
            get { return this.truck; }
            set { this.truck = value; }
        }

        public EProductOrder PrOrder
        {
            get { return this.prOrder; }
            set { this.prOrder = value; }
        }
    }
}
