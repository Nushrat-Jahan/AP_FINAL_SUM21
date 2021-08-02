using BEL;
using BLL.MapperConfig;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductService
    {
        /*
        static ProductService()
        {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSettings>());
        }*/
        public static List<string> GetProductNames()
        {
            return ProductRepo.GetProductNames();
        }

        public static List<ProductModel> GetProducts()
        {
            var products = ProductRepo.GetProducts();
            var data = AutoMapper.Mapper.Map<List<product>, List<ProductModel>>((List<product>)products);
            return data;
        }

        public static void AddProduct(ProductModel pt)
        {
            var p = AutoMapper.Mapper.Map<ProductModel, product>(pt);
            ProductRepo.AddProduct(p);
        }

        public static ProductDetail GetProductDetail(int id)
        {
            var p = ProductRepo.GetProductDetail(id);
            var ptdetail = AutoMapper.Mapper.Map<product, ProductDetail>((product)p);
            return ptdetail;
        }

        public static List<ProductDetail> GetProductWithDetails()
        {
            var data = ProductRepo.GetProducts();
            var pdetails = AutoMapper.Mapper.Map<List<product>, List<ProductDetail>>(data);
            return pdetails;
        }
    }
}
