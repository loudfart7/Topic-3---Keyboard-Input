using System.Xml.Linq;

namespace Topic_3___Keyboard_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Joel
            //Greetings
            string name = "YOU";
            string computer = "COMPUTER";
            string age;
            string year;

            Console.WriteLine($"{computer}:");
            Console.WriteLine("Whats your name?");

            Console.WriteLine();

            Console.WriteLine($"{name}:");
            name = Console.ReadLine();
            name = name.ToUpper();

            Console.WriteLine();

            Console.WriteLine($"{computer}:");
            Console.WriteLine($"Hello, {name}! How old are you..?");

            Console.WriteLine();

            Console.WriteLine($"{name}:");
            age = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine($"{computer}:");
            Console.WriteLine($"{age}...");

            Console.WriteLine();

            Console.WriteLine($"{computer}:");
            Console.WriteLine($"You're old.. Much older than I am... Could you maybe give me a name?");

            Console.WriteLine();

            Console.WriteLine($"{name}:");
            computer = Console.ReadLine();
            computer = computer.ToUpper();

            Console.WriteLine();

            Console.WriteLine($"{computer}:");
            Console.WriteLine($"{computer}? Okay... Well what year is it?");

            Console.WriteLine();

            Console.WriteLine($"{name}:");
            year = Console.ReadLine();

            Console.Clear();



        }
    }
}
