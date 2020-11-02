using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal? Price { get; set; }
        public decimal? Units { get; set; }

        public EProduct()
        {
        }

        public EProduct(int id, string name, string categoty, string description, decimal? price, decimal? units)
        {
            Id = id;
            Name = name;
            Category = categoty;
            Description = description;
            Price = price;
            Units = units;
        }

        public override string ToString()
        {
            return $"{Id}. {Name}";
        }
    }
}
