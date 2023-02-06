using System;
using System.Collections.Generic;
using System.Text;

namespace Task2._6._2023
{
    internal class Product
    {
        public int _no;
        public string Name;
        public double Price;
        private static int _totalCount;

        public Product()
        {
            _totalCount++;
            _no = _totalCount;
        }

    }
}
