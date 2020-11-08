using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EProductOrder
    {
        public int Id { get; set; }
        public int? OrderID { get; set; }
        public EOrder order;
        public int? ProductID { get; set; }
        public int? Units { get; set; }

        public EProductOrder()
        {
        }

        public EProductOrder(int id, int? orderID, EOrder order, int? productID, int? units)
        {
            Id = id;
            OrderID = orderID;
            this.order = order;
            ProductID = productID;
            Units = units;
        }

        public EOrder Order
        {
            get { return this.order; }
            set { this.order = value; }
        }
    }
}
