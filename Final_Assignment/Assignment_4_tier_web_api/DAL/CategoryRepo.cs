using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryRepo
    {
        static InventoryMSEntities context;
        static CategoryRepo() {
            context = new InventoryMSEntities();
        }
        public static List<string> GetCategoryNames() {
            var data = context.categories.Select(e => e.Name).ToList();
            return data;
        }
        public static List<category> GetCategories() {
            return context.categories.ToList();
        }

        public static void AddCategory(category c)
        {
            context.categories.Add(c);
            context.SaveChanges();
        }

        public static object GetCategoryDetail(int id)
        {
            return context.categories.FirstOrDefault(e => e.Id == id);
        }
    }
}
