using NeuroBuddy.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Model
{
    class CategoryManger : CategoryMangerInterface
    {
        List<Category> categories = new List<Category>(); 
        public IEnumerable<Category>GetCategories()
        {
            return categories;
        }
        
       public  void AddCategory(Category newCategory)
        {
            categories.Add(newCategory);
        }

        public void RemoveCategory(Category Category)
        {
            if(!categories.Contains(Category))
                throw new Exception("Tasks list doesn't contain this task");

            categories.Remove(Category);
        }

        public void ModifyCategory(Category oldCategory, Category newCategory)
        {
            var indexOld = categories.IndexOf(oldCategory);
            if (indexOld == -1)
                throw new Exception($"Category: {oldCategory.Name} doesn't exist, couldn't modify list");

            categories.Remove(oldCategory);
            categories.Add(newCategory);
        }
    }
}
