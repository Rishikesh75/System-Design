class TreeType
{
    public string Name { get; }
    public string Color { get; }
    public string Texture { get; }

    public TreeType(string name, string color, string texture)
    {
        Name = name; Color = color; Texture = texture;
    }

    public void Draw(int x, int y)
    {
        Console.WriteLine($"Draw {Name} at ({x},{y}) using {Color}, {Texture}");
    }
}

class Tree
{
    private int X, Y;              // extrinsic
    private TreeType Type;        // shared intrinsic flyweight

    public Tree(int x, int y, TreeType type)
    {
        X = x; Y = y; Type = type;
    }

    public void Draw() => Type.Draw(X, Y);
}

static class TreeFactory
{
    private static readonly Dictionary<string, TreeType> _types = new();

    public static TreeType GetTreeType(string name, string color, string texture)
    {
        string key = $"{name}_{color}_{texture}";
        if (_types.TryGetValue(key, out var t)) return t;
        var newType = new TreeType(name, color, texture);
        _types[key] = newType;
        return newType;
    }

    public static int TypesCount() => _types.Count;
}

class Forest
{
    private readonly List<Tree> _trees = new();

    public void PlantTree(int x, int y, string name, string color, string texture)
    {
        var type = TreeFactory.GetTreeType(name, color, texture);
        _trees.Add(new Tree(x, y, type));
    }

    public void Draw()
    {
        foreach (var t in _trees) t.Draw();
    }
}