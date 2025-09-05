using System;
namespace ProtoTypePattern
{

    interface Student
    {
        Student Clone();
        void display();
    }

    class Prototype : Student
    { 
        
        public Student Clone()
        {
            return new Prototype();
        }
        public void display()
        {
            Console.WriteLine("This is New Prototype");
        }
    }



    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("ProtoType Pattern");
            Prototype prototype = new Prototype();
            Student prototype_1 = prototype.Clone();
             prototype_1.display();
            return;
        }
        
    }





}

