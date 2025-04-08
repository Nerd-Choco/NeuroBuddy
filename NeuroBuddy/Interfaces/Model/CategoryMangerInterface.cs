using NeuroBuddy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Interfaces.Model
{
    interface CategoryMangerInterface
    {
        IEnumerable<Category> GetCategories();
        
        void AddCategory(Category NewCategory);

        void RemoveCategory(Category Category);

        void ModifyCategory(Category OldCategory, Category NewCategory);

    }
}
