using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4.Models
{
    struct Product
    {
        public string Name;
        public double Price;
        public double Protein;
        public double Fat;
        public double Carbs;
        public double Calories;

        public Product(string name, double price, double protein, double fat, double carbs, double calories)
        {
            Name = name;
            Price = price;
            Protein = protein;
            Fat = fat;
            Carbs = carbs;
            Calories = calories;
        }

        public override string ToString()
        {
            return $"{Name} - {Price} UAH | P:{Protein}g F:{Fat}g C:{Carbs}g Cal:{Calories}";
        }
    }

    class Cart
    {
        private Product[] products;
        private int count = 0;

        public Cart(int size = 50)
        {
            products = new Product[size];
        }

        public void AddProduct(Product p)
        {
            if (count < products.Length)
            {
                products[count] = p;
                count++;
                Console.WriteLine($"Added: {p.Name}");
            }
            else
            {
                Console.WriteLine("Cart is full!");
            }
        }

        public double GetTotalPrice()
        {
            double sum = 0;
            for (int i = 0; i < count; i++)
                sum += products[i].Price;
            return sum;
        }

        public (double protein, double fat, double carbs, double calories) GetTotalNutrition()
        {
            double protein = 0, fat = 0, carbs = 0, calories = 0;
            for (int i = 0; i < count; i++)
            {
                protein += products[i].Protein;
                fat += products[i].Fat;
                carbs += products[i].Carbs;
                calories += products[i].Calories;
            }
            return (protein, fat, carbs, calories);
        }

        public void ShowCart()
        {
            Console.WriteLine("\n=== Your Order ===");
            for (int i = 0; i < count; i++)
                Console.WriteLine(products[i]);

            Console.WriteLine($"Total price: {GetTotalPrice()} UAH");

            var nutri = GetTotalNutrition();
            Console.WriteLine($"Proteins: {nutri.protein}g | Fats: {nutri.fat}g | Carbs: {nutri.carbs}g | Calories: {nutri.calories}");

            if (nutri.protein > 120) Console.WriteLine("Too many proteins!");
            if (nutri.fat > 100) Console.WriteLine("Too many fats!");
            if (nutri.carbs > 300) Console.WriteLine("Too many carbs!");
            if (nutri.calories > 2000) Console.WriteLine("Too many calories!");

            Console.WriteLine($"Purchase date: {DateTime.Now}");
        }
    }
}
