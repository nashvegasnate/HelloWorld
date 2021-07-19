using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Howdy Y'all!!");
            Console.ReadKey();
            //without this line^, you get an exit code 0

            var animals = new string[] { "Triceratops", "Gorilla", "Corgi", "Toucan" };

            foreach (var animal in animals)
            {
                if (animal.Length >= 6)
                    Console.WriteLine(animal);
            }

            Console.WriteLine("Choose a greeting style by entering the corresponding number");
            Console.WriteLine("1 - Southern");
            Console.WriteLine("2 - Hawaiian");
            Console.WriteLine("3 - Swedish");

            var chosenGreeting = Console.ReadLine();

            switch (chosenGreeting)
            {
                case "1":
                    Console.WriteLine("Howdy");
                    break;

                case "2":
                    Console.WriteLine("Aloha");
                    break;

                case "3":
                    Console.WriteLine("Hej Hej");
                    break;

                default:
                    Console.WriteLine("Howdy");
                    break;

            }
          
        }
    }
}
