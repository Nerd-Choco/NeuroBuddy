using NeuroBuddy.Model.DataContainers;

class TaskManager : TaskManagerInterface
{
    List<NeuroTask> tasks;

    public void AddTask(NeuroTask newTask)
    {
        tasks.Add(newTask);
    }
  

    public IEnumerable<NeuroTask> GetTasks()
    {
        return tasks;
    }

    public void RemoveTask(NeuroTask task)
    {
        if (!tasks.Contains(task))
            throw new Exception("At TaskManager.RemoveTask(NeuroTask task): Tasks list doesn't contain this task");

        tasks.Remove(task);
    }
    public void ModifyTask(NeuroTask OldTask, NeuroTask NewTask)
    {
  //      OldTask.SetTask(NewTask);
    }
    public TaskManager(List<NeuroTask> tasks)
    {
        this.tasks.AddRange(tasks);
    }
    public TaskManager() 
    {
        tasks = new List<NeuroTask>();
    }
}