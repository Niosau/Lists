using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
          //  part1();
                part2();



        }



        public static void part1()
        {
            Random random = new Random();

            List<string> colours = new List<string>();

            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("Please enter a colour: ");
                colours.Add(Console.ReadLine());
                random.Next(0, colours.Count);
            }
            Console.WriteLine(string.Join(", ", colours));

            int randomIndex = Random.Shared.Next(0, colours.Count);

            string randomColour = colours[randomIndex];
            Console.WriteLine(randomColour);
        }



        public static void part2()
        {

            Random random = new Random();
            List<int> numbers = new List<int>();
            int numbersToAdd, min, max;
            Console.WriteLine("How many numbers do you want to add? ");
            numbersToAdd = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the minimum value? ");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the maximum value? ");
            max = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbersToAdd; i++)
            {
                int randomNumber = random.Next(min, max + 1);
                numbers.Add(randomNumber);
            }
            Console.WriteLine(string.Join(", ", numbers));

            Console.WriteLine("What number do you want to search for? ");
            int numberToSearch = int.Parse(Console.ReadLine());
            int count = numbers.Count(n => n == numberToSearch);
            Console.WriteLine($"The number {numberToSearch} appears {count} times in the list.");

            Console.WriteLine("What number should i replace with 0?");
            int numberToReplace = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == numberToReplace)
                {
                    numbers[i] = 0;
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
            
            Console.WriteLine("i will now make them all 0");
            for (int i = 0; i < numbers.Count; i++)
            {
                numbers[i] = 0;
            }
            Console.WriteLine(string.Join(", ", numbers));
            Console.WriteLine($"im now adding new random numbers from {min} to {max} ");
            for (int i = 0; i < numbersToAdd; i++)
            {
                int randomNumber = random.Next(min, max + 1);
                numbers[i] = randomNumber;
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
