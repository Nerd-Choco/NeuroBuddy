using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddyWinForms
{
    public interface IDatabaseManager
    {
        Userdatabase GetUserdatabase(string username);
    }
}
