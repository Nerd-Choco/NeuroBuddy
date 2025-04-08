using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Model
{
    class Category
    {
        public string Name { get; set; }
        public Category Rootcategory { get; set; }
        bool isRoot { get; set; }


        public List<Category> SubCategories;

        public void SetCategory(Category newCategory)
        {
            this.Name = newCategory.Name;
            this.isRoot = newCategory.isRoot;
            this.Rootcategory = newCategory.Rootcategory;
            this.SubCategories.Clear();
            this.SubCategories.AddRange(newCategory.SubCategories);
        }
        public Category(string name,Category root)
        {
            Name = name;
            Rootcategory = root; 
        }
        public Category(string name)
        {
            this.isRoot = isRoot;
        }

        public Category() { }

    }
}
