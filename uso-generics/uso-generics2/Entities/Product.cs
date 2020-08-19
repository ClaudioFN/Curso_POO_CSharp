﻿using System;
using System.Globalization;

namespace Entities {
    class Product : IComparable {

        public string Name { get; set; }
        public double Price { get; set; }

        public Product (string name, double price) {
            Name = name;
            Price = price;
        }

        public override string ToString() {
            return "Product: " + Name + "; Price: " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) {
            if (!(obj is Product)) {
                throw new ArgumentException("Comparing Error: argument is not a product!");
            }

            Product other = obj as Product;
            return Price.CompareTo(other.Price);
        }
    }
}