using BEL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_4_tier_web_api.Controllers
{
    public class OrderController : ApiController
    {
        [Route("api/Order/GetAll")]
        [HttpGet]
        public List<OrderModel> GetAllOrders()
        {
            return OrderService.GetAllOrders();
        }

        [Route("api/Order/PlaceOrder")]
        [HttpPost]
        public void OrderPlace(List<ShowOrderModel> ordered)
        {
            OrderModel o = new OrderModel();
            o.Status = "Pending";
            double sum = 0;
            foreach (var item in ordered)
            {
                sum += (item.Price * item.Quantity);
            }
            o.Amount = sum;
            int orderId = OrderService.AddOrder(o);
            foreach (var item in ordered)
            {
                item.Order_id = orderId;
                OrderService.AddProductOrder(item);
            }
        }



        [Route("api/Order/{id}")]
        [HttpGet]
        public OrderModel GetOrders(int id)
        {
            return OrderService.GetOrders(id);
        }
    }
}
