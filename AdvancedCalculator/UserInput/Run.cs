using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInput
{
    public class Run
    {
        Queue<string> userInput;

        public Run()
        {
            userInput = new Queue<string>();
        }
        public void PrintDirections()
        {
            Console.WriteLine("Please enter in a three part expression");
            Console.WriteLine("e.g., 3 + 2");
            Console.WriteLine("Valid operators include: +, -, *, /, and ^");
        }
        public string GetUserInput()
        {
            switch (userInput.Count)
            {
                case 0:
                    Console.WriteLine("Provide the first expression: ");
                    return SanitizeUserExpression(Console.ReadLine());
                case 1:
                    Console.WriteLine("Provide the operator: ");
                    return SanitizeUserOperator(Console.ReadLine());
                default:
                    Console.WriteLine("Provide the second expression: ");
                    return SanitizeUserExpression(Console.ReadLine());
            }
        }
        public string SanitizeUserExpression(string input)
        {
            foreach (char character in input)
            {
                if (char.IsLetter(character))
                {
                    Console.WriteLine("This doesn't appear to be valid");
                    return GetUserInput();
                }
            }
            return input;
        }
        public string SanitizeUserOperator(string input)
        {
            string[] availableOperators = { "+", "-", "*", "/", "^" };
            if (availableOperators.Contains(input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("This doesn't appear to be valid");
                return GetUserInput();
            }
        }
        public Queue<string> InitiateCalculator()
        {
            PrintDirections();
            while (userInput.Count < 3)
            {
                userInput.Enqueue(GetUserInput());
            }
            return userInput;
        }
    }
}
