using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        public EProduct product;
        public int? Units { get; set; }

        public EProductOrder()
        {
        }

        public EProductOrder(int id, int? orderID, int? productID, int? units, EOrder order, EProduct product)
        {
            Id = id;
            OrderID = orderID;
            ProductID = productID;
            Units = units;
            Order = order;
            Product = product;
        }

        public EOrder Order
        {
            get { return this.order; }
            set { this.order = value; }
        }

        public EProduct Product
        {
            get { return this.product; }
            set { this.product = value; }
        }

        public override string ToString()
        {
            return $"{Product.Name} - {Units}";
        }
    }
}
