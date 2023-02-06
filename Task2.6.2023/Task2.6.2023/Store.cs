using System;
using System.Collections.Generic;
using System.Text;

namespace Task2._6._2023
{
    internal class Store
    {
        public int DairyProductCount;
        public int AlcoholPercentLimit;

        Product[] products = new Product[0];

        public void AddProduct(Product product)
        {
            if (DairyProductCount <= 100 && AlcoholPercentLimit <= 40)
            {
                Array.Resize(ref products, products.Length + 1);
                products[products.Length - 1] = product;

            }
        }

        public Product HasProductByNo(int num)
        {

            for (int i = 0; i < products.Length; i++)
            {

                if (products[i]._no == num)
                {

                    return products[i];
                }

            }
            throw new Exception();

        }

        public Dairy[] GetDairyProducts()
        {
            Dairy[] dairies = new Dairy[0];
            foreach (var item in products)
            {
                if (item is Dairy)
                {

                    Dairy dry = (Dairy)item;
                    Array.Resize(ref dairies, dairies.Length + 1);
                    dairies[dairies.Length - 1] = dry;

                }

            }

            return dairies;

        }
        public Drink[] GetDrinkproducts()
        {
            Drink[] drinks = new Drink[0];

            foreach (var item in products)
            {
                if (item is Drink)
                {

                    Drink drk = (Drink)item;
                    Array.Resize(ref drinks, drinks.Length + 1);
                    drinks[drinks.Length - 1] = drk;

                }

            }
            return drinks;
        }
    }
}
