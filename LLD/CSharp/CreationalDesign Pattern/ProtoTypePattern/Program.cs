namespace PrototypePattern;

public interface Iproduct
{
    public Iproduct Clone();
}

public class TV : Iproduct
{
    public string Name = "TV_1";
    public Iproduct Clone()
    {
        return (Iproduct)this.MemberwiseClone();
    }
}


public class Program
{

    public static void Main()
    {
        TV tv = new TV();
        TV tv2 = (TV)tv.Clone();
        if (tv != tv2 && tv.Name == tv2.Name)
        {
            Console.WriteLine("Prototype Pattern Is working Fine heree..");
        }
    }


}
