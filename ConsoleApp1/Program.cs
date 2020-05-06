using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {

            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please, choose an option: ");

            object userChoise = Console.ReadLine();
            var choise = int.TryParse(userChoise.ToString(), out int c) ? c : userChoise;

            switch (choise)
            {
                case int i when i == 2:
                case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Your choise is VB {0} {1}");
                    break;
               
                case int i when i == 1:
                case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("C#");
                    break;

                default:
                    break;
            }

            

            return -1;
        }
    }
}
