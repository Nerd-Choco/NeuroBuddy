using Microsoft.VisualBasic.ApplicationServices;

namespace NeuroBuddy.Core;

public class Userdatabase
{
    public string Username { get; set; }

    public List<NeuroCategory> Categories { get; }

    public List<NeuroTask> Tasks { get; }

    public List<NeuroSchedule> Schedules { get; }

    public Userdatabase(string username, IEnumerable<NeuroCategory>? categories = null, IEnumerable<NeuroTask>? tasks = null, IEnumerable<NeuroSchedule>? schedules = null)
    {
        Username = username;

        Categories = new List<NeuroCategory>();
        Tasks = new List<NeuroTask>();
        Schedules = new List<NeuroSchedule>();

        if (categories != null)
            Categories.AddRange(categories);

        if (tasks != null)
            Tasks.AddRange(tasks);

        if (schedules != null)
            Schedules.AddRange(schedules);
    }
}
