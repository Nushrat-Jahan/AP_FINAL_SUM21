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
    public class CategoryController : ApiController
    {
        [Route("api/Category/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
            return CategoryService.GetCategoryNames();
        }
        [Route("api/Category/GetAll")]
        [HttpGet]
        public List<CategoryModel> GetAllCategories() {
            return CategoryService.GetCategories();
        }
       
        [Route("api/Category/Add")]
        [HttpPost]
        public void Add(CategoryModel cate)
        {
            CategoryService.AddCategory(cate);
        }
        [Route("api/Category/All/Details")]
        public List<CategoryDetail> GetCategoryWithDetails()
        {
            return CategoryService.GetCategoryWithDetails();
        }
        [Route("api/Category/{id}/Details")]
        public CategoryDetail GetCategoryDetail(int id)
        {
            return CategoryService.GetCategoryDetail(id);
        }
    }
}
