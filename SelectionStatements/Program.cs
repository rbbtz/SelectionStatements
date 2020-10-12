using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 20);

            Console.WriteLine("Guess my Favorite Number!");


            var userInput = int.Parse(Console.ReadLine());

            if (userInput < favNumber)
            {
                Console.WriteLine($"too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"too high");

            }
            else
            {
                Console.WriteLine($"Nevermind");
            }

            Console.WriteLine($"What is your favorite subject?");

            var subject = Console.ReadLine().ToLower();



            switch (subject)
            {
                case "math":
                    Console.WriteLine($"maths");
                    break;
                case "history":
                    Console.WriteLine($"History repeats itself!");
                    break;
                case "art":
                    Console.WriteLine($"Creativity pushes us forward");
                    break;
                case "science":
                    Console.WriteLine($"Ah, the natural world");
                    break;
                case "english":
                    Console.WriteLine($"Words never say what they mean, don't mean what they say");
                    break;
                case "physics":
                    Console.WriteLine($"It's all about entropy, right?");
                    break;
                case "chemistry":
                    Console.WriteLine($"These PH levels!");
                    break;
                case "Programming":
                    Console.WriteLine($"Let's collab!");
                    break;
                default:
                    Console.WriteLine($"You're an original");
                    break;

            }


        }
    }
}
