using NeuroBuddy.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Model
{
    class CategoryManger:CategoryMangerInterface
    {
        List<Category> Categories; 
        public IEnumerable<Category>GetCategories()
        {
            return Categories;
        }
       public  void AddCategory(Category newCategory)
        {
            Categories.Add(newCategory);
        }
        public void RemoveCategory(Category Category)
        {
            if(!Categories.Contains(Category))
                throw new Exception("Tasks list doesn't contain this task");
            return;
            Categories.Remove(Category);
        }
        public void ModifyCategory(Category oldCategory, Category newCategory)
        {
            oldCategory.SetCategory(newCategory);
        }
    }
}
