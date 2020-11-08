using DataLayer;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoLayer
{
    public class ProductBO
    {
        /*Method to search a product on the database*/
        public EProduct GetProductById(int id)
        {
            EProduct product = new EProduct();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                PRODUCT p = null;
                if (id > 0)
                {
                    p = db.PRODUCTS.Find(id);
                }

                product.Id = p.Id;
                product.Name = p.Product_Name;
                product.Category = p.Category;
                product.Description = p.Product_Description;
                product.Price = p.Price;
                product.Units = p.Units;
                product.Image = p.Image_path;

                return product;
            }
        }

        /*Method to add to a list all the products in the database*/
        public List<EProduct> LoadProducts(string filter)
        {
            List<EProduct> products = new List<EProduct>();
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                var myList = from p in db.PRODUCTS.ToList()
                             select new EProduct
                             {
                                 Id = p.Id,
                                 Name = p.Product_Name,
                                 Category = p.Category,
                                 Description = p.Product_Description,
                                 Price = p.Price,
                                 Units = p.Units,
                                 Image = p.Image_path
                             };

                if (!string.IsNullOrEmpty(filter))
                {
                    myList = myList.Where(p => p.Name.Equals(filter));
                }
                foreach (var pd in myList)
                {
                    products.Add(new EProduct(pd.Id, pd.Name, pd.Category, pd.Description,
                        pd.Price, pd.Units, pd.Image));
                }

                return products;
            }
        }

        /*Method to save a product in the database*/
        public void Save(EProduct product, int pid = 0)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {

                PRODUCT prod = null;
                if (pid == 0)
                {
                    prod = new PRODUCT();
                }
                else
                {
                    prod = db.PRODUCTS.Find(pid);
                }

                prod.Id = product.Id;
                prod.Product_Name = product.Name;
                prod.Category = product.Category;
                prod.Product_Description = product.Description;
                prod.Price = product.Price;
                prod.Units = product.Units;
                prod.Image_path = product.Image;

                if (pid == 0)
                {
                    db.PRODUCTS.Add(prod);
                }
                else
                {
                    db.Entry(prod).State = System.Data.Entity.EntityState.Modified;
                }

                db.SaveChanges();
            }
        }

        /*Method to delete a product*/
        public void Delete(int pid)
        {
            using (IRONMONGERYEntities db = new IRONMONGERYEntities())
            {
                PRODUCT prod;
                prod = db.PRODUCTS.Find(pid);
                db.PRODUCTS.Remove(prod);
                db.SaveChanges();
            }
        }
    }
}
