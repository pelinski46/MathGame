using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Class
{
    public class Game
    {
        public static void AdditionGame()
        {
            Console.WriteLine("Addition game selected");
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 15);
                secondNumber = random.Next(1, 15);
                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();
                if (double.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer is correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect");
                }
                Console.WriteLine($"Game over. your final score is {score}");
            }
        }

        public static void SubstractionGame()
        {   
            Console.WriteLine("Substraction game selected");
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 15);
                secondNumber = random.Next(1, 15);
                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();
                if (double.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer is correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect");
                }
                Console.WriteLine($"Game over. your final score is {score}");
            }
        }

        public static void MultiplicationGame()
        {
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 15);
                secondNumber = random.Next(1, 15);
                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();
                if (double.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer is correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect");
                }
                Console.WriteLine($"Game over. your final score is {score}");
            }
        }

        public static void DivisionGame()
        {
            Console.WriteLine("Division game selected");
            var random = new Random();
            int firstNumber;
            int secondNumber;
            int score = 0;
            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 15);
                secondNumber = random.Next(1, 15);
                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();
                if (double.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer is correct");
                    score++;
                }
                else
                {
                    Console.WriteLine("Your answer is incorrect");
                }
                Console.WriteLine($"Game over. your final score is {score}");
            }
        }
    }

}
