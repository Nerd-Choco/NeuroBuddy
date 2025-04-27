using NeuroBuddy.Core;
using NeuroBuddy.Interfaces;

namespace NeuroBuddy.Mocks
{
    public class UserdatabaseManagerMock : IDatabaseManager
    {
        public Userdatabase GetUserdatabase(string username)
        {
            var db = new Userdatabase("Meow");
            db.Categories.Add(new NeuroCategory("Health"));
            db.Categories.Add(new NeuroCategory("House"));
            db.Categories.Add(new NeuroCategory("Fun"));
            db.Categories.Add(new NeuroCategory("Workout", db.Categories.First()));

            db.Tasks.Add(new NeuroTask("Cleaning", db.Categories[1]));
            db.Tasks.Add(new NeuroTask("Attack on Titans", db.Categories[2]));
            db.Tasks.Add(new NeuroTask("30Min Cardio Daily", db.Categories[3]));

            return db;
        }
    }
}
