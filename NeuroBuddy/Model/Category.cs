using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddy.Model
{
    class Category
    {
        public string Name { get; set; }
        public Category? RootCategory { get; set; }
        bool isRoot => SubCategories.Count > 0;

        public List<Category> SubCategories;

        public Category(string name, Category? root = null)
        {
            Name = name;
            SubCategories = new List<Category>();
            this.RootCategory = root;
        }
    }
}
