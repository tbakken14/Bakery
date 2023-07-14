using System;

namespace Bakery{
    class Program {
        static void Main() {
            Models.IFoodItem x = new Models.Bread();
            x.Amount = 5;
            Console.WriteLine(x.Amount);
        }
    }
}