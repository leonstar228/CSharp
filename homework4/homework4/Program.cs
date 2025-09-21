using System;
using homework4.Models;


class Program
{
    static void Main()
    {
        Product[] shop =
        {
            new Product("Apple", 10, 0.3, 0.2, 14, 52),
            new Product("Bread", 25, 8, 2, 50, 265),
            new Product("Chicken", 100, 27, 5, 0, 239),
            new Product("Milk", 30, 3, 3, 5, 60)
        };

        Cart cart = new Cart();

        Console.WriteLine("=== Store ===");
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nChoose a product (number) or 0 to finish:");
            for (int i = 0; i < shop.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {shop[i]}");
            }

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                if (choice == 0)
                {
                    running = false;
                }
                else if (choice > 0 && choice <= shop.Length)
                {
                    cart.AddProduct(shop[choice - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid choice!");
                }
            }
        }

        cart.ShowCart();
    }
}
