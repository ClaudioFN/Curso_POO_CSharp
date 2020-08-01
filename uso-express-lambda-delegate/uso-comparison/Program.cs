using System;
using System.Collections.Generic;
using Entities;

namespace uso_comparison {
    class Program {
        static void Main(string[] args) {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Notebook", 1200.00));
            list.Add(new Product("Tablet", 450.00));

            // Comparison<Product> comp = CompareProducts; // Delegate via uso de variável
            // Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); // Uso de Expressão Lambda - dá pra usar passando dentro do Sort

            list.Sort(CompareProducts); // Delegate: usando a sobre carga existente no Sort usou método auxiliar para fazer a ordenação

            foreach (Product n in list) {
                Console.WriteLine(n);
            }
            
        }

        static int CompareProducts(Product p1, Product p2) {
            return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        }
    }
}
