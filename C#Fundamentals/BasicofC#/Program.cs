namespace HelloWorld;
class Program
{
    public class Node
    {
        public int Value;
        public Node? Next; // nullable struct to allow null

        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hi This is Coure Where I Completly Learn About Csharp...");

        //Numeric Data Types..
        int a = 10;
        long b = 20;
        float c = 30.5f;
        double d = 40.5;
        bool isTrue = true;
        Console.WriteLine($"int:{a} long:{b} float:{c} double:{d} Bool:{isTrue}");


        //String Data Type..
        char ch = 'a';
        string str = "Hello, World!";
        Console.WriteLine($"char:{ch} string:{str}");


        //Convert the String into Numeric Data Types..
        string s = "1234";
        int intValue = int.Parse(s);
        double doubleValue = double.Parse(s);
        Console.WriteLine($"String to int:{intValue} String to double:{doubleValue}");

        //Convert Numeric Data Types into String..
        int num = 5678;
        string strValue = num.ToString();
        Console.WriteLine($"int to String:{strValue}");

        //Operattors
        //Arthimatic Operators: + - * / %;
        //Logical Operators: && || !;
        //Assignment Operators: = += -= *= /= %=;   
        //postincreament : ++ , -- ;

        //var Keyword
        var ans = "This is the var Operator...";
        Console.WriteLine($"This is the var operator:{ans}");

        //Const KeyWord: We cann't use var Here..
        const int myConst = 100;
        Console.WriteLine($"This is the const keyword:{myConst}");

        Console.WriteLine("Enter the Input....");
        if (int.TryParse(Console.ReadLine(), out int result))
        {
            Console.WriteLine($"You Entered Value is:{result}");
        }
        else
        {
            Console.WriteLine("Invalid input. Could not parse to int.");
        }

        Console.WriteLine("Enter the Number...");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number % 2 == 0)
            {
                Console.WriteLine("The Number is Even...");
            }
            else
            {
                Console.WriteLine("The Number is Odd...");
            }
            switch (number)
            {
                case 1:
                    Console.WriteLine("The Number is One...");
                    break;
                case 0:
                    Console.WriteLine("The Number is Zero...");
                    break;
                default:
                    Console.WriteLine("The Number is Neither One Nor Zero's...");
                    break;
            }

            for (int i = 0; i < number; i++)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();

            int i = 0;
            while (i != number)
            {
                Console.WriteLine($"{i}\t");
                i++;
            }
            Console.WriteLine();

            //Conditional Operator
            int value = number % 2 == 0 ? 1 : 0;
        }
        else
        {
            Console.WriteLine("Invalid input. Could not parse to int.");
        }

        try
        {
            Console.WriteLine("Enter a number to divide by zero:");
            if (int.TryParse(Console.ReadLine(), out int divNum))
            {
                int divResult = divNum / 0;
            }
            else
            {
                Console.WriteLine("Invalid input. Could not parse to int.");
            }
        }
        catch (Exception Ex)
        {
            Console.WriteLine($"Exception Occured:{Ex.Message}");
        }

        //foreach(char c in value)
        int[] arr = { 1, 2, 3, 4, 5 };
        foreach (int item in arr)
        {
            Console.WriteLine($"Array Items:{item}");
        }

        int n;
        int.TryParse(Console.ReadLine(), out n);
        int[] newarr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter element {i}: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        //List in c#
        List<int> list = new List<int>();
        list.Append(int.Parse(Console.ReadLine()));
        foreach (int i in list)
        {

        }

        //Dictionary
        Dictionary<int, string> dict = new Dictionary<int, string>();
        dict.Add(1, "Rishi");
        foreach (var i in dict)
        {
            Console.WriteLine(i.Key + ": " + i.Value);
        }
    }

    public void SampleMethod()
    {
        Console.WriteLine("This is a Sample Method...");
    }

    public int add(int a, int b)
    {
        return a + b;
    }

}