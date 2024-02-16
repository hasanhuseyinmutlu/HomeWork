using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private List<Category> _categories = new();
        public CategoryManager()
        {
            _categories.Add(new Category {Id =0, CategoryName =" Yazilim" });
        }
        public void Add(Category category)
        {
            category.Id = _categories.Count ;
            _categories.Add(category);
            
            Console.WriteLine($"{category} eklendi");
        }

        public void Delete(int id)
        {
            var deleteCategory = _categories.FirstOrDefault(c => c.Id == id);
            Console.WriteLine($"{deleteCategory} silindi");
        } 

        public List<Category> GetAll()
        {
            foreach (Category category in _categories)
            {
                Console.WriteLine($"{category.Id}, {category.CategoryName}");
            }
            return _categories;
        }

        public void Update(Category category)
        {
            var newCategory = _categories.FirstOrDefault(c => c.Id == category.Id);
            newCategory.CategoryName = category.CategoryName;
        }
    }
}
