using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace NeuroBuddy.Model
{
    public class Category
    {
        public string Name { get; set; }
        public Category? RootCategory { get; private set;}
        public bool HasChildren => SubCategories.Count > 0;

        public bool HasRoot => RootCategory != null;

        public List<Category> SubCategories;

        public Category() { }
        public Category(string name, Category? root = null)
        {
            Name = name;
            SubCategories = new List<Category>();
            this.RootCategory = root;
        }

        public void AddChildCategory(Category child)
        {
            if (child.HasRoot)
                throw new Exception("Trying to add a new child category which already has a root");

            if (SubCategories.Contains(child))
                throw new Exception("This category already contains this child category");

            child.RootCategory = this;
            SubCategories.Add(child);
        }
    
        public void RemoveChild(Category child)
        {
            if (!SubCategories.Contains(child))
                throw new Exception("Can't remove child category, it's not a child of this category");

            SubCategories.Remove(child);
            child.RootCategory = null;
        }
    }
}
