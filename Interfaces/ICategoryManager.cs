using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddyWinForms
{
    public interface ICategoryManager
    {
        void Add(NeuroCategory category);

        void Remove(NeuroCategory category);

        IEnumerable<NeuroCategory> GetAllCategories();
    }
}
