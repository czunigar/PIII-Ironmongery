using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EServiceOrder
    {
        public int Id { get; set; }
        public int? OrderID { get; set; }
        public EOrder order;
        public int? ServiceID { get; set; }

        public EServiceOrder()
        {
        }

        public EServiceOrder(int id, int? orderID, EOrder order, int? serviceID)
        {
            Id = id;
            OrderID = orderID;
            this.order = order;
            ServiceID = serviceID;
        }
        public EOrder Order
        {
            get { return this.order; }
            set { this.order = value; }
        }
    }
}
