using System;
using System.Runtime.InteropServices;
using System.Text;
namespace HelloWorld
{
    class Program
    {
        struct student
        {
            int id;
            string name;
        }
        class Teacher
        {
            //Data Members..
            //Member Functions..
            private string name;
            //Property
            public string Name { get { return name; } set { name = value; } }

            public override string ToString()
            {
                return name;
            }
        }

        public static void HelloWorld()
        {
            Console.WriteLine("Hello, World!");
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static void  chagenumber(ref int number)
        {
            number = number + 10;
        }
        public static void tempfunc([Optional] int b)
        {

        }
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            ////DataTypes :(int,Long),(float,double),(char,string),bool
            //int intvar = 25;
            //Console.WriteLine($"int:{intvar}");
            //long longvar = 23232L;
            //Console.WriteLine($"long:{longvar}");
            //float floatvar = 25.5f;
            //Console.WriteLine($"float:{floatvar}");
            //double doublevar = 55.55D;
            //Console.WriteLine($"double:{doublevar}");
            //char charvar = 'A';
            //Console.WriteLine($"char:{charvar}");
            //string stringvar = "Hello C#";
            //Console.WriteLine($"string:{stringvar}");
            //bool boolvar = true;
            //Console.WriteLine($"Bool:{boolvar}");

            ////Convert string Number;
            //int number = Convert.ToInt32("1234");
            //Console.WriteLine($"Converted Number:{number}");
            //float floatnumber = Convert.ToSingle("12.34");
            //Console.WriteLine($"Converted Float Number:{floatnumber}");
            //double doublenumber = Convert.ToDouble("56.78");
            //Console.WriteLine($"Converted Double Number:{doublenumber}");


            ////Operators : Arithmetic,Relational,Logical,Bitwise 
            ////Arthmetic Operators: + , - , * , /(Division) , %(Remainder) , ++ , --,
            ////Realational Operators: == , != , > , < , >= , <=
            ////Logical Operators: && , || , !
            ////Bitwise Operators: &(AND), |(OR) , ^(XOR) , ~(NOT) , <<(left shift) , >>(Right Shift)
            ////Assignment Operators: = , += , -= , *= , /= , %=

            ////var Keyword similar to auto keyword in C++
            //var varint = 100;
            //var varstring = "This is a var string";
            //var vardouble = 99.99;

            ////Cont KeyWord Once Declared Cannot be changed
            //const double pi = 3.14159;
            ////pi = 12; This will give error


            ////Odd or Even Number
            //int num;
            //Console.WriteLine("Enter a number to check Odd or Even:");
            //num = Convert.ToInt32(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine($"{num} is Even Number");
            //}
            //else
            //{
            //    Console.WriteLine($"{num} is Odd Number");
            //}

            //switch (num%2)
            //{
            //    case 0:
            //        Console.WriteLine($"{num} is Even Number (Using Switch)");
            //        break;
            //    case 1:
            //        Console.WriteLine($"{num} is Odd Number (Using Switch)");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;

            //}
            //for(int ival=0;ival<4;i++)
            //{
            //    Console.WriteLine($"For Loop Iteration:{ival}");
            //}
            //int i = 0;
            //while (i != 4)
            //{
            //    Console.WriteLine($"While Loop Iteration:{i}");
            //    i++;
            //}
            ////int.TryParse(Console.ReadLine(), out i); return Boolean True if no Error Else Return False..
            ////float.TryParse(Console.ReadLine(), out floatnumber);
            //char.TryParse(Console.ReadLine(),out charvar);

            //string value = @"This is String that Escapes \n \t \r \\etc..";
            //Console.WriteLine($"Verbitose String:{value}");

            //string scheck;
            //scheck = Console.ReadLine();
            //if(!string.IsNullOrEmpty(scheck))
            //{
            //    if (scheck == string.Empty)
            //    {
            //        Console.WriteLine("This is a Empty String...");
            //    }
            //}
            //int n =Convert.ToInt32(Console.ReadLine());
            //int[] arr = new int[n];
            //for(int ir=0;ir<n;ir++)
            //{
            //     arr[ir] = Convert.ToInt32(Console.ReadLine());
            //}
            //List<int> list = new List<int>();
            //for (int ir = 0; ir < n; ir++)
            //{
            //    list.Add(Convert.ToInt32(Console.ReadLine()));
            //}
            //for(int ir = 0;ir<n;ir++)
            //{
            //    Console.WriteLine($"List Element {ir}:{list[ir]}");
            //}
            //Dictionary<int,string>dict = new Dictionary<int, string>();
            //dict.Add(1, "One");
            //foreach(KeyValuePair<int,string>item in dict)
            //{
            //     Console.WriteLine($"Key:{item.Key},Value:{item.Value}");
            //}

            ////c++ : Push_back c#: Add
            //Out: Need not be Intialized Before Use
            //ref: Need to be Intialized Before Use
            StringBuilder str = new StringBuilder();
            HelloWorld();
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine($"Original Number:{n}");
            chagenumber(ref n);
            Console.WriteLine($"Changed Number:{n}");
        }
    }
}