using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductRepo
    {

        static InventoryMSEntities context;
        static ProductRepo()
        {
            context = new InventoryMSEntities();
        }
        public static List<string> GetProductNames()
        {
            var data = context.products.Select(e => e.Name).ToList();
            return data;
        }
        public static List<product> GetProducts()
        {
            return context.products.ToList();
        }

        public static void AddProduct(product p)
        {
            context.products.Add(p);
            context.SaveChanges();
        }

        public static object GetProductDetail(int id)
        {
            return context.products.FirstOrDefault(e => e.Id == id);
        }
    }
}
