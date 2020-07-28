using System;
using System.Collections.Generic;
using System.Text;

namespace Entities {
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product (string name, double price) {
            Name = name;
            Price = price;
        }
        // Implementar o GetHashCode e o Equals faz com que a compração deixe de ser por referência de memória
        // e seja feita pela regra estabelecida
        public override int GetHashCode() {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj) {
            if (!(obj is Product)) {
                return false;
            }
            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
        }
    }
}
