
class TaskManager : TaskManagerInterface
{
    List<Task> tasks;

    public void AddTask(Task newTask)
    {
        tasks.Add(newTask);
    }

    public IEnumerable<Task> GetTasks()
    {
        return tasks;
    }

    public void RemoveTask(Task task)
    {
        if (!tasks.Contains(task))
            throw new Exception("At TaskManager.RemoveTask(Task task): Tasks list doesn't contain this task");

        tasks.Remove(task);
    }
}