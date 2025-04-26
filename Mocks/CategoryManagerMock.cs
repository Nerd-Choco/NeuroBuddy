using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddyWinForms
{
    internal class CategoryManagerMock : ICategoryManager
    {
        List<NeuroCategory> cats;
        public CategoryManagerMock()
        {
            cats = new()
            {
                new NeuroCategory("Health"),
                new NeuroCategory("House"),
                new NeuroCategory("Chores")
            };

            cats.Add(new NeuroCategory("Workout", cats.First()));
        }

        public void Add(NeuroCategory category)
        {
            cats.Add(category);
        }

        public IEnumerable<NeuroCategory> GetAllCategories()
        {
            return cats;
        }

        public void Remove(NeuroCategory category)
        {
            cats.Remove(category);
        }
    }
}
