using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== TICKET PRICE CALCULATOR =====");

            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age;

            if (int.TryParse(input, out age))
            {
                double price;

                if (age <= 12 || age >= 65)
                {
                    price = 7.00;
                }
                else
                {
                    price = 10.00;
                }

                Console.WriteLine($"Ticket price: GHC {price}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
