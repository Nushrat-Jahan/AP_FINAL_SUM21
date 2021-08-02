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
    public class CategoryService
    {
      /*  static CategoryService() {
            AutoMapper.Mapper.Initialize(config => config.AddProfile<AutoMapperSettings>());
        }*/
        public static List<string> GetCategoryNames() {
            return CategoryRepo.GetCategoryNames();
        }

        public static List<CategoryModel> GetCategories() {
            var categories = CategoryRepo.GetCategories();
            var data = AutoMapper.Mapper.Map<List<category>, List<CategoryModel>>(categories);

            /* var categories = CategoryRepo.GetCategories();
            var data = CategoryRepo.GetCategories();
             foreach (var c in categories) {
                 var ct = new CategoryModel()
                 {
                     Id = c.Id,
                     Name = c.Name
                 };
                 data.Add(ct);
             }*/
            return data;
        }

        public static void AddCategory(CategoryModel cate)
        {
            //var c = new category() { Id = cate.Id, Name = cate.Name };
            var c = AutoMapper.Mapper.Map<CategoryModel, category>(cate);
            CategoryRepo.AddCategory(c);
        }

        public static CategoryDetail GetCategoryDetail(int id)
        {
            var c = CategoryRepo.GetCategoryDetail(id);
            var catedetail = AutoMapper.Mapper.Map<category, CategoryDetail>((category)c);
            return catedetail;
        }

        public static List<CategoryDetail> GetCategoryWithDetails()
        {
            var data = CategoryRepo.GetCategories();
            var cdetails = AutoMapper.Mapper.Map<List<category>, List<CategoryDetail>>(data);
            return cdetails;
        }

       
    }
}
