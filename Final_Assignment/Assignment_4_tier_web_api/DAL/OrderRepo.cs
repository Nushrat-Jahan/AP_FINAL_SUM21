using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderRepo
    {
        static InventoryMSEntities context;
        static OrderRepo()
        {
            context = new InventoryMSEntities();
        }

        public static List<order> GetAllOrders()
        {
            return context.orders.ToList();
        }

        public static int AddOrder(order o)
        {
            o.Created_at = DateTime.Now;
            context.orders.Add(o);
            context.SaveChanges();
            return o.Id;
        }

        public static void AddProductOrder(showorder p)
        {
            context.showorders.Add(p);
            context.SaveChanges();
        }

       

        public static order GetOrders(int id)
        {
            return context.orders.FirstOrDefault(e => e.Id == id);
        }
    }
}
