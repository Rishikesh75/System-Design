namespace FactoryDesignPattern;


public interface IVechicle
{
    public void Vechilespec();
}

public class Car : IVechicle
{
    public void Vechilespec()
    {
        Console.WriteLine("This is the Car");
    }
}

public interface Factory
{
    public IVechicle CreateVechicle();
}

public class TwoWheelerFactory : Factory
{
    public IVechicle CreateVechicle()
    {
        return new Car();
    }
}

public class Program
{
    public static void Main(string[] args)
    {

        Factory factory = new TwoWheelerFactory();
        IVechicle vech1 = factory.CreateVechicle();
        IVechicle vech2 = factory.CreateVechicle();
        if (!ReferenceEquals(vech1, vech2))
        {
            Console.WriteLine("Factory Pattern is Working Fine.....");
        }


        return;
    }

}
