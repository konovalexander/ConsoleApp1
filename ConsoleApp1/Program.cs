using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Main(string[] args)
        {

            Console.WriteLine("1 [One], 2 [Two]");
            Console.Write("Please, choose an option: ");

            object userChoise = Console.ReadLine();
            var choise = int.TryParse(userChoise.ToString(), out int c) ? c : userChoise;

            switch (choise)
            {
                case int i when i == 2:
                case string s when s.Equals("two", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Your choise is Two");
                    break;
               
                case int i when i == 1:
                case string s when s.Equals("One", StringComparison.OrdinalIgnoreCase):
                    Console.WriteLine("Your choise is One");
                    break;

                default:
                    break;
            }

            

            return -1;
        }
    }
}
