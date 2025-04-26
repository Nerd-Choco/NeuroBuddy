using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroBuddyWinForms
{
    public class UserdatabaseManagerMock : IDatabaseManager
    {
        public Userdatabase GetUserdatabase(string username)
        {
            var db = new Userdatabase();
            db.Username = username;
            db.CategoryManager = new CategoryManagerMock();

            return db;
        }
    }
}
