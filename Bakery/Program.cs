using System;

namespace Bakery{
    class Program {
        static void Main() {
            Models.Bread x = new Models.Bread();
            x.Quantity = 5;
            Console.WriteLine(x.Quantity);
        }
    }
}