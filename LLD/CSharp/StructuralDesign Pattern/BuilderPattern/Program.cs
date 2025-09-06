using System;
using static BuilderPattern.Program;
namespace BuilderPattern
{
    public class Program
    {
        public interface Vechile
        {
            void display();
        }

        public class Bike : Vechile
        {
            public void display()
            {
                Console.WriteLine("Bike Vechile");
            }
        }

        public class car : Vechile
        {
            public void display()
            {
                Console.WriteLine("car Vechile");
            }

        }

        public abstract class Employee
        {
            protected Vechile vechile;
            protected Employee(Vechile vechile)
            {
                this.vechile = vechile;
            }
            public abstract void Display();

        }


        public class Manager : Employee
        {
            public Manager(Vechile vehicle) : base(vehicle)
            {

            }

            public override void Display()
            {
                vechile.display();
            }
        }

        public static void Main(string[] args)
        {
            
        }
    }



}

