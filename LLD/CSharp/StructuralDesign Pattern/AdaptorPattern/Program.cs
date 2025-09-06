using System;

namespace AdaptorPattern
{
    /*This is the Target Interface*/
    interface IPrinter
    {
        void print();
    }

    /*This is the Adaptee Interface*/
    public interface ILegacyPrinter
    {
        void printLegacy();
    }

    public class IndianLegacyPrinter : ILegacyPrinter
    {
        public void printLegacy()
        {
            Console.WriteLine("This is Indian Legacy Printer");
        }
    }

    // Adapter implements Target interface
    public class Adaptor : IPrinter
    {
        private  ILegacyPrinter legacyPrinter;

        public Adaptor(ILegacyPrinter legacyPrinter)
        {
            this.legacyPrinter = legacyPrinter;
        }

        public void print()
        {
            legacyPrinter.printLegacy();
        }
    }

    // Target class just uses the adapter
    public class TargetClass
    {
        private IPrinter printer;

        public TargetClass()
        {
            printer = new Adaptor(new IndianLegacyPrinter());
        }

        public void PrintTargetClass()
        {
            printer.print();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            TargetClass target = new TargetClass();
            target.PrintTargetClass();
        }
    }
}