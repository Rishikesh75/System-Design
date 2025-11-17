namespace SingletonDesignpattern
{
    public class SingletonClass
    {
        private static SingletonClass _instance = new SingletonClass();

        public static SingletonClass Instance
        {
            get { return _instance; }
        }
    }



    public class Program
    {

        public static void Main(string[] args)
        {
            SingletonClass obj1 = SingletonClass.Instance;
            SingletonClass obj2 = SingletonClass.Instance;
            if (ReferenceEquals(obj1, obj2))
            {
                Console.WriteLine("Singleton Pattern is working Fine.....");
            }
            return;
        }
    }



}

