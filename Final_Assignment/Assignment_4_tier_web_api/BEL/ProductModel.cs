using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Category_id { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> Qty { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Created_at { get; set; }
        public Nullable<System.DateTime> Updated_at { get; set; }
        public Nullable<System.DateTime> Deleted_at { get; set; }
        public string Created_by { get; set; }
        public string Updated_by { get; set; }
        public string Deleted_by { get; set; }
        

    }
}
