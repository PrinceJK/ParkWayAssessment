using System;

namespace TransactionSurchargeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the amount to be transferred: ");
            var input = Console.ReadLine();
            if (decimal.TryParse(input, out var amount))
            {
                var result = CalculateSurcharge.Calculate(amount);
                if (result == 0)
                {
                    Console.WriteLine("Sorry, you are not allowed to make transactions above 999999999 yet");
                }
                else if (result == -1)
                {
                    Console.WriteLine("Please enter a number greater than zero");
                }
                else
                {
                    Console.WriteLine($"Your fee debit is: {result}");
                }

            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
