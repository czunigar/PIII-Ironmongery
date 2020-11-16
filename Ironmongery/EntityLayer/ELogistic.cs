using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ELogistic
    {
        public int Id { get; set; }
        public int? VehicleNumber { get; set; }
        public int DriverId { get; set; }
        public EUser driver;
        public string Active { get; set; }


        public ELogistic()
        {
        }

        public ELogistic(int id, int? vehicle_Number, int driverId, EUser driver, string active)
        {
            Id = id;
            VehicleNumber = vehicle_Number;
            DriverId = driverId;
            this.driver = driver;
            Active = active;
        }

        public EUser Driver
        {
            get { return this.driver; }
            set { this.driver = value; }
        }
    }
}
