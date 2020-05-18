using System;

namespace ConsoleApp1
{
    class Person
    {
        public string personName;
        public int personAge;

        public Person(string name, int age)
        {
            personName = name;
            personAge = age;
        }
        public Person() { }
        public void Display()
        {
            Console.WriteLine($"Name: {personName}, Age: {personAge}");
        }
    }

    public struct MyStruct
    {
        public MyStruct(int x, int y) : this()
        {
            X = x;
            Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public int z;
    }

    public class MyClass
    {
        public int my { get; set; }
        public MyClass()
        {
            my = 0;
        }
        public int GetStruct()
        {
            return my;
        }
        public void SetStruct(int a, int b)
        {
            //my.X = a;
            //my.z = b;
        }
    }

    enum testEnum
    {
        one = 1,
        two = -2,
        three = 10
    }

    class Program
    {
        static void TestPerson(ref Person p)
        {
            p.personAge = 99;
            p = new Person("Nikki", 100);

        }
        public static ref string SimpleReturn(string[] strArray, int position)
        {
            return ref strArray[position];
        }

        static int AddWrapper(int x, int y)
        {
            return Add();

            int Add()
            {
                return x + y;
            }
        }

        static void DisplayFancyMessage(ConsoleColor textColor = ConsoleColor.DarkGreen, ConsoleColor backgroundColor = ConsoleColor.Gray, string message = "message")
        {
            ConsoleColor oldTextColor = Console.ForegroundColor;
            ConsoleColor oldBackgroundColor = Console.BackgroundColor;

            Console.ForegroundColor = textColor;
            Console.BackgroundColor = backgroundColor;
            Console.WriteLine(message);

            Console.ForegroundColor = oldTextColor;
            Console.BackgroundColor = oldBackgroundColor;
        }

        static void TesterMethod(string[] args)
        {
            Console.WriteLine($"You sent me {args?.Length ?? 0} arguments.");
        }

        static (int a, string b) MyFunc()
        {
            int a = 10;
            string b = "str";
            return (a, b);
        }

        struct Point
        {
            public int X;
            public int Y;
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public (int, int) Deconstr() => (X, Y);
        }

        static void Main(string[] args)
        {
            Point p = new Point(1, 2);
            (int, int) res = p.Deconstr();
            Console.WriteLine(res.Item1);
            Console.WriteLine(res.Item2);
            (int a, int) t = (p.X, p.Y);
            Console.WriteLine($"{t.a} {t.Item2}");
            //int d;
            Console.WriteLine(int.TryParse("125", out _));
        }
    }
}
