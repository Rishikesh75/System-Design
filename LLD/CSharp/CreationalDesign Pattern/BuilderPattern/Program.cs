using System;

namespace BuilderPattern
{
    // Product class
    public class House
    {
        public string Wall;
        public string Roof;
        public string Windows;

        public void ShowHouse()
        {
            Console.WriteLine($"House with {Wall}, {Roof}, {Windows}");
        }
    }

    /* Builder Interface */
    public interface IBuilder
    {
        IBuilder CreateWall();
        IBuilder CreateRoof();
        IBuilder CreateWindows();
        House GetHouse();
    }

    // Concrete Builder
    public class ModernBuilder : IBuilder
    {
        private House house = new House();

        public IBuilder CreateWall()
        {
            house.Wall = "Modern Wall";
            return this;
        }

        public IBuilder CreateRoof()
        {
            house.Roof = "Modern Roof";
            return this;
        }

        public IBuilder CreateWindows()
        {
            house.Windows = "Modern Windows";
            return this;
        }

        public House GetHouse()
        {
            return house;
        }
    }

    // Director (optional, but good practice in Builder Pattern)
    public class Director
    {
        private IBuilder builder;

        public Director(IBuilder builder)
        {
            this.builder = builder;
        }

        public House Construct()
        {
            return builder.CreateWall()
                          .CreateRoof()
                          .CreateWindows()
                          .GetHouse();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            IBuilder builder = new ModernBuilder();
            Director director = new Director(builder);

            House modernHouse = director.Construct();
            modernHouse.ShowHouse();
        }
    }
}
