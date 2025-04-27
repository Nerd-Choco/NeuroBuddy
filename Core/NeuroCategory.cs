namespace NeuroBuddy.Core;

public class NeuroCategory
{
    List<NeuroCategory> childrenCats;

    public IEnumerable<NeuroCategory> Children => childrenCats;

    public string Name { get; set; }

    NeuroCategory? root;
    public NeuroCategory? Root
    {
        get
        {
            return root;
        }
        set
        {
            // if I already had a root before, then remove myself from its children list first
            if (root != null)
                root.RemoveChild(this);

            // if I'm gonna have an actual root next instead of null, then tell it that I'm a new child
            if (value != null)
                value.AddChild(this);

            // set my root whehter the target is null or actual root
            root = value;
        }
    }

    public List<NeuroTask> ChildrenTasks {get;}

    public NeuroCategory(string name, NeuroCategory? root = null)
    {
        childrenCats = new List<NeuroCategory>();
        ChildrenTasks = new List<NeuroTask>();

        Name = name;

        if (root != null)
        {
            this.root = root;
            root.AddChild(this);
        }
    }

    void AddChild(NeuroCategory child)
    {
        childrenCats.Add(child);
    }

    void RemoveChild(NeuroCategory child)
    {
        childrenCats.Remove(child);
    }

    // should only be calleed from NeuroTask
    public void AddTask(NeuroTask task)
    {
        if (task.Category != this)
            throw new Exception("Cannot add task to this category, it's not set as its parent");

        if (ChildrenTasks.Contains(task))
            return;
        
        ChildrenTasks.Add(task);
    }

    // should only be calleed from NeuroTask
    public void RemoveTask(NeuroTask task)
    {
        if (!ChildrenTasks.Contains(task))
            throw new Exception("This task doesn't belong to this category, cannot be removed");

        ChildrenTasks.Remove(task);
    }

    public override string ToString()
    {
        if (Root != null)
            return $"CatName: {Name}, Child of: {Root.Name}";

        return $"CatName: {Name}, Root category";
    }
}