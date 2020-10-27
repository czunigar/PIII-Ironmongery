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
        public string Categoty { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Units { get; set; }

        public EProduct()
        {
        }

        public EProduct(int id, string name, string categoty, string description, double price, int units)
        {
            Id = id;
            Name = name;
            Categoty = categoty;
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
