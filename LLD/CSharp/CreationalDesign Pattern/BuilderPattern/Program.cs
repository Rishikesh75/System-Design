namespace BuilderPattern;
public class Computer
{
    public string? Monitor;

    public string? Mouse;

    public string? keyboard;
}



public class ComputerBuilder
{
    private Computer computer = new Computer();
    public ComputerBuilder BuildMonitor(string? s)
    {
        this.computer.Monitor = s;
        return this;
    }
    public ComputerBuilder BuildMouse(string? s)
    {
        this.computer.Mouse = s;
        return this;
    }

    public ComputerBuilder BuildKeyBoard(string? s)
    {
        this.computer.keyboard = s;
        return this;
    }

    public Computer GetBuilderValue()
    {
        return this.computer;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ComputerBuilder computerbuilder = new ComputerBuilder();
        Computer computer = computerbuilder.BuildMonitor(Console.ReadLine()).BuildMouse(Console.ReadLine()).BuildKeyBoard(Console.ReadLine()).GetBuilderValue();
        Console.WriteLine($"Buildervalue:{computer.Monitor} {computer.Mouse} {computer.keyboard}");
    }
}
