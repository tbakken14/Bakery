using System;

namespace Bakery
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(UserInterfaceModels.Banners.header);
            orderLoop();
        }
        private static void orderLoop()
        {
            bool isContinueOrder = true;
            Models.Bread bread = new Models.Bread();
            Models.Pastry pastry = new Models.Pastry();
            while (isContinueOrder)
            {
                bool isBreadOrder = getIsBreadOrder();
                int quantity = getQuantity();
                if (isBreadOrder)
                {
                    bread.Quantity = quantity;
                }
                else
                {
                    pastry.Quantity = quantity;
                }
                isContinueOrder = getIsContinueOrder();
            }
            checkoutMessage(bread.getCost() + pastry.getCost());
        }
        private static void checkoutMessage(int cost)
        {
            Console.WriteLine("Thanks for shopping at the Bakery");
            Console.WriteLine("The cost of your order is $" + cost.ToString());
            Console.WriteLine("Goodbye");
            Console.WriteLine();
        }
        private static bool getIsBreadOrder()
        {
            string input;
            Console.WriteLine("What would you like to order?");
            do
            {
                Console.Write("Enter (pastry) or (bread): ");
                input = Console.ReadLine();
            } while (input != "pastry" && input != "bread");
            Console.WriteLine();
            return input == "bread";
        }

        private static bool getIsContinueOrder()
        {
            string input;
            Console.WriteLine("Would you like to edit your order or checkout?");
            do
            {
                Console.Write("Enter (edit) or (checkout): ");
                input = Console.ReadLine();
            } while (input != "edit" && input != "checkout");
            Console.WriteLine();
            return input == "edit";
        }
        private static int getQuantity()
        {
            string input;
            int quantity;
            Console.WriteLine("How many would you like to purchase?");
            do
            {
                Console.Write("Enter a number: ");
                input = Console.ReadLine();
            } while (!Int32.TryParse(input, out quantity));
            Console.WriteLine();
            return quantity;
        }
    }
}