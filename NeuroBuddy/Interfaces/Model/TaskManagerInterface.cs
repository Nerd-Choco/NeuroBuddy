using NeuroBuddy.Model.DataContainers;

interface TaskManagerInterface
{
    IEnumerable<NeuroTask> GetTasks();

    void AddTask(NeuroTask newTask);

    void RemoveTask(NeuroTask task); // can't repeat same task interface

    void ModifyTask(NeuroTask OldTask, NeuroTask NewTask);

}