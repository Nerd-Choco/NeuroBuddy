interface TaskManagerInterface
{
        IEnumerable<Task> GetTasks();

        void AddTask(Task newTask);

        void RemoveTask(Task task); // can't repeat same task interface
}