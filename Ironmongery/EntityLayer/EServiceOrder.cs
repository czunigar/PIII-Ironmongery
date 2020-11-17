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
        public EService service;
        public EServiceOrder()
        {
        }

        public EServiceOrder(int id, int? orderID, int? serviceID, EOrder order, EService service)
        {
            Id = id;
            OrderID = orderID;
            ServiceID = serviceID;
            Order = order;
            Service = service;
        }

        public EOrder Order
        {
            get { return this.order; }
            set { this.order = value; }
        }

        public EService Service
        {
            get { return this.service; }
            set { this.service = value; }
        }
    }
}
