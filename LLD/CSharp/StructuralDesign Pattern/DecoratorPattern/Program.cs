using System;
using System.Collections.Generic;

namespace DecoratorPattern
{
    public class Program
    {
        // Base interface
        public interface ICoffee
        {
            void Display();
        }

        // Concrete component
        public class SimpleCoffee : ICoffee
        {
            public void Display()
            {
                Console.WriteLine("This is a Simple Coffee");
            }
        }

        // Abstract decorator
        public abstract class CoffeeDecorator : ICoffee
        {
            protected ICoffee _coffee;  // reference to wrapped object

            public CoffeeDecorator(ICoffee coffee)
            {
                _coffee = coffee;
            }

            public virtual void Display()
            {
                _coffee.Display();
            }
        }

        // Concrete decorator - Milk
        public class MilkDecorator : CoffeeDecorator
        {
            public MilkDecorator(ICoffee coffee) : base(coffee) { }

            public override void Display()
            {
                base.Display();
                Console.WriteLine(" + Milk added");
            }
        }

        // Concrete decorator - Sugar
        public class SugarDecorator : MilkDecorator
        {
            public SugarDecorator(ICoffee coffee) : base(coffee) { }

            public override void Display()
            {
                base.Display();
                Console.WriteLine(" + Sugar added");
            }
        }

        // Main program
        public static void Main(string[] args)
        {
            ICoffee coffee = new SimpleCoffee();

            // Add sugar
            coffee = new SugarDecorator(coffee);

            // Final decorated coffee
            coffee.Display();

            Console.ReadLine();
        }
    }
}
