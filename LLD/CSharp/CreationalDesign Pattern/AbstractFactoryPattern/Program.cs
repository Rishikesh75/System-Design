namespace AbstarctFactoryPattern;
public interface ISofa
{

}

public interface IChair
{

}

public class ModernChair : IChair
{

}

public class ModernSofa : ISofa
{

}

public interface IFactory
{
    public ISofa CreateSofa();

    public IChair CreateChair();
}

public class ModernFactory : IFactory
{
    public ISofa CreateSofa()
    {
        return new ModernSofa();
    }

    public IChair CreateChair()
    {
        return new ModernChair();
    }
}



public class Program
{

    public static void Main(string[] args)
    {

    }
}
