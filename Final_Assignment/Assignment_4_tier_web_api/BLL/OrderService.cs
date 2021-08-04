using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class OrderService
    {
        public static List<OrderModel> GetAllOrders()
        {
            var orders = OrderRepo.GetAllOrders();
            var data = AutoMapper.Mapper.Map<List<order>, List<OrderModel>>(orders);
            return data;
        }

        public static int AddOrder(OrderModel o)
        {
            var order = AutoMapper.Mapper.Map<OrderModel, order>(o);
            return OrderRepo.AddOrder(order);
        }

        public static void AddProductOrder(ShowOrderModel item)
        {
            var productOrder = AutoMapper.Mapper.Map<ShowOrderModel, showorder>(item);
            OrderRepo.AddProductOrder(productOrder);
        }



        public static OrderModel GetOrders(int id)
        {
            var order = OrderRepo.GetOrders(id);
            return AutoMapper.Mapper.Map<order, OrderModel>(order);
        }
    }
}
