using System;
namespace SingletonDesignpattern
{
    public class School
    {
        private static readonly School _instance = new School();
        public static School Instance
        {
            get { return _instance; }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }


    public class Prgram
    {
        public static void Main(string[] args)
        {
            School s1 = School.Instance;
            s1.Name = "ABC High School";

            School s2 = School.Instance;
            Console.WriteLine($"{s2.Name}");

        }
    }
    

}

