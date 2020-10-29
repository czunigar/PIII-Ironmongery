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
        public short? VehicleNumber { get; set; }
        public int DriverId { get; set; }
        public EUser Driver { get; set; }
        public bool? Active { get; set; }

        public ELogistic()
        {
        }

        public ELogistic(int id, short? vehicle_Number, int driverId, EUser driver, bool? active)
        {
            Id = id;
            VehicleNumber = vehicle_Number;
            DriverId = driverId;
            Driver = driver;
            Active = active;
        }
    }
}
