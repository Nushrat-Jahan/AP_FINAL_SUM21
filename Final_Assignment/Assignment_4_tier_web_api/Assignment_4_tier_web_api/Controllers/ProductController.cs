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
    public class ProductController : ApiController
    {
       
        [Route("api/Product/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return ProductService.GetProductNames();
        }
        [Route("api/Product/GetAll")]
        [HttpGet]
        public List<ProductModel> GetAllProducts()
        {
            return ProductService.GetProducts();
        }

        [Route("api/Product/Add")]
        [HttpPost]
        public void Add(ProductModel pt)
        {
            ProductService.AddProduct(pt);
        }
        [Route("api/Product/All/Details")]
        public List<ProductDetail> GetProductWithDetails()
        {
            return ProductService.GetProductWithDetails();
        }
        [Route("api/Product/{id}/Details")]
        public ProductDetail GetProductDetail(int id)
        {
            return ProductService.GetProductDetail(id: id);
        }
    }
}
