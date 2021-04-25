using System;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            double modulusNumber = 0;

            Console.Write("Enter First Number: ");
            double firstNumber;
            string firstNumberInput = Console.ReadLine();
            bool checkFirstNumberInput = double.TryParse(firstNumberInput, out firstNumber);

            while (!checkFirstNumberInput)
            {
                Console.Write("Please Enter A Number: ");
                firstNumberInput = Console.ReadLine();
                checkFirstNumberInput = double.TryParse(firstNumberInput, out firstNumber);
            }

            Console.Write("Enter Second Number: ");
            double secondNumber;
            string secondNumberInput = Console.ReadLine();
            bool checkSecondNumberInput = double.TryParse(secondNumberInput, out secondNumber);
            
            while (!checkSecondNumberInput)
            {
                Console.Write("Please Enter A Number: ");
                secondNumberInput = Console.ReadLine();
                checkSecondNumberInput = double.TryParse(secondNumberInput, out secondNumber);
            }

            modulusNumber = firstNumber % secondNumber;

            Console.WriteLine("The Remainder of {0} divided by {1} is: {2}", firstNumber, secondNumber, modulusNumber);
        }
    }
}
