using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    class ProductServiceInvoice
    {
        public EProduct product;
        public EService service;

        public ProductServiceInvoice()
        {
        }

        public ProductServiceInvoice(EProduct product, EService service)
        {
            this.product = product;
            this.service = service;
        }

        public override string ToString()
        {
            return $"{product.Name}, " + $"{service.Name}" + $"{product.Price}" ;
        }
    }
}
