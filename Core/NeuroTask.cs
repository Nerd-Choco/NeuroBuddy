using Microsoft.VisualBasic.Logging;

namespace NeuroBuddy.Core;

public class NeuroTask
{
    public string Name {get; set;}

    NeuroCategory category;
    public NeuroCategory Category
    {
        get
        {
            return category;
        }
        set
        {
            category.RemoveTask(this);

            if (value == null)
                throw new Exception("Cannot have a task without a category");

            category = value;
            category.AddTask(this);
        }
    }

    public List<NeuroSchedule> Scheduled {get;}

    public List<NeuroSchedule> Logged {get;}

    public NeuroTask(string name, NeuroCategory category, IEnumerable<NeuroSchedule>? scheduled = null, IEnumerable<NeuroSchedule>? logged = null)
    {
        Name = name;

        this.category = category;
        category.AddTask(this);

        if (scheduled == null)
            Scheduled = new List<NeuroSchedule>();
        else
            Scheduled = scheduled.ToList();
        
        if (logged == null)
            Logged = new List<NeuroSchedule>();
        else
            Logged = logged.ToList();

    }

}