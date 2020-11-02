using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }

        public EService()
        {
        }

        public EService(int id, string serviceName, string category, string serviceDescription, decimal? price)
        {
            Id = id;
            Name = serviceName;
            Category = category;
            Description = serviceDescription;
            Price = price;
        }
    }
}
