using system;
using static AbstractFactoryPattern.program;
namespace AbstractFactoryPattern;

public interface Ichair
{
    void sit();
}

public interface Isofa
{
    void Releax();
}
/*There are Concreate Products*/
public class Modernchair : Ichair
{
    public void sit()
    {
        Console.WriteLine("This is Modern Chair");
    }
}

public class Modernsofa : Isofa
{
    public void Releax()
    {
        Console.WriteLine("This is the Modern Sofa");
    }
}

public class Antiquechair : Ichair
{
    public void sit()
    {
        Console.WriteLine("This is the Antique Chair");
    }
}
public class Antiquesofa : Isofa
{
    public void Releax()
    {
        Console.WriteLine("This is the An");
    }
}
/*abstract Factory*/
public interface Factory
{
    Ichair CreateChair();
    Isofa CreateSofa();
}

public class ModernFurniture : Factory
{
    public Ichair CreateChair() => new Modernchair();

    public Isofa CreateSofa() => new Modernsofa();
}

public class AntiqueFurniture : Factory
{
    public Ichair CreateChair() => new Antiquechair();

    public Isofa CreateSofa() => new Antiquesofa();
}

public class program
{
    
    /*These are Products*/
    public static void Main(string[] args)
    {
        Console.WriteLine("Abstract Factory Pattern");
    }
}
