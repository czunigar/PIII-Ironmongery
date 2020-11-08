using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EWarehouse
    {
        public int Id { get; set; }
        public TimeSpan? EntryTime { get; set; }
        public int? TruckId { get; set; }
        public ELogistic truck;
        public TimeSpan? ExitTime { get; set; }

        public EWarehouse()
        {
        }

        public EWarehouse(int id, TimeSpan? entryTime, int? truckId, ELogistic truck, TimeSpan? exitTime)
        {
            Id = id;
            EntryTime = entryTime;
            TruckId = truckId;
            this.truck = truck;
            ExitTime = exitTime;
        }

        public ELogistic Truck
        {
            get { return this.truck; }
            set { this.truck = value; }
        }
    }
}
