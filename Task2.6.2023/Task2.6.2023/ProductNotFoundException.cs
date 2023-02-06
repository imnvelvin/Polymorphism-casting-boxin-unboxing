using System;
using System.Collections.Generic;
using System.Text;

namespace Task2._6._2023
{
    internal class ProductNotFoundException: Exception
    {

        ProductNotFoundException(string message) : base(message)
        {
            Console.WriteLine("Product Not Found ");


        }


    }
}