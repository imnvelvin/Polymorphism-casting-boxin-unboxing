using System;

namespace Task2._6._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Store store = new Store();
            Product product1 = new Product
            {
                Name = "Cola  2L ",
                Price = 20
            };
            Product product2 = new Product
            {
                Name = "Fanta",
                Price = 1.50
            };
            Drink drink = new Drink
            {
                Name = "Pepsi",
                Price = 15,
                AlcoholPercent = 20
            };
            Drink drink2 = new Drink
            {
                Name = "GreenWord",
                Price = 50,
                AlcoholPercent = 20
            };
            store.AddProduct(product1);
            store.AddProduct(product2);
            store.AddProduct(drink);
            store.AddProduct(drink2);
        }
    }
}
