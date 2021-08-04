using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEL
{
    public class OrderModel
    {
        public int Id { get; set; }
        public System.DateTime Created_at { get; set; }
        public string Status { get; set; }
        public Nullable<double> Amount { get; set; }
        public ICollection<ShowOrderModel> Showorders { get; set; }
    }
}
