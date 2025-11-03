using System;
namespace SingletonDesignpattern
{
    public class Trimble
    {
        private static Trimble trimble = new Trimble();

        public static Trimble Instance()
        {
            return trimble;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Trimble t1 = Trimble.Instance();
            Trimble t2 = Trimble.Instance();
            if(t1 == t2)
            {
                Console.WriteLine("Sucessfully Implemented Singletonpattern");
            }
            else
            {
                Console.WriteLine("Not SucessFully Implemendted Singletonpattern");
            }
        }
    }
    

}

