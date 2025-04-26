public class NeuroCategory
{
    List<NeuroCategory> children;

    public IEnumerable<NeuroCategory> Children => children;

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

    public NeuroCategory(string name, NeuroCategory? root = null)
    {
        children = new List<NeuroCategory>();

        Name = name;

        if (root != null)
        {
            this.root = root;
            root.AddChild(this);
        }
    }

    void AddChild(NeuroCategory child)
    {
        children.Add(child);
    }

    void RemoveChild(NeuroCategory child)
    {
        children.Remove(child);
    }

    public override string ToString()
    {
        if (Root != null)
            return $"CatName: {Name}, Child of: {Root.Name}";

        return $"CatName: {Name}, Root category";
    }
}