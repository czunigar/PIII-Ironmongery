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
        public string Image { get; set; }

        public EProduct()
        {
        }

        public EProduct(int id, string name, string category, string description, decimal? price, decimal? units, string image)
        {
            Id = id;
            Name = name;
            Category = category;
            Description = description;
            Price = price;
            Units = units;
            this.Image = image;
        }

        public string ProductDetails()
        { 
            return $"Category: {Category} {Environment.NewLine}Description: {Description}{Environment.NewLine}Price: {Price}";
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
