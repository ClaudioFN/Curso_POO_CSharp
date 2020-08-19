using System;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace uso_delegates {

    // Delegate: type safety de declaracoes
    delegate double BinaryNumericOperation(double n1, double n2); // O delegate deve ser declarado seguindo a mesma logica de parametrizacao que o metodo referenciado

    class Program {
        /*
         * Delegate comentado na aula 225
        static void Main(string[] args) {
            double a = 10;
            double b = 12;

            double result = CalculationService.Max(a, b);
            double result2 = CalculationService.Sum(a, b);
            double result3 = CalculationService.Square(a);

            BinaryNumericOperation op = CalculationService.Sum;

            Console.WriteLine("Result: " +  result + "\nResult2: " + result2 + "\nResult3: " + result3);
            Console.WriteLine("\nOperation: " + op(a, b));

        }

        */

        // Delegate Func: uso direto com listas e que tem retorno em IEnumerable
        static void Main(string[] args){

            List<Product> list = new List<Product>();
            list.Add(new Product("Tv", 900.0));
            list.Add(new Product("Mouse", 50.0));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("Hd Case", 80.90));

            Product p;

            Func<Product, string> func = NameUpper;
            Func<Product, string> func2 = p => p.Name.ToUpper();
            //List<string> result = list.Select(NameUpper).ToList(); // Chamada de metodo direta
            //List<string> result = list.Select(func).ToList(); // Chamada via Delegate Func

            List<string> result = list.Select(func2).ToList();
            List<string> result2 = list.Select(p => p.Name.ToUpper()).ToList(); // Colocar a expressao lambda direto funciona

            foreach (string s in result) {
                Console.WriteLine(s);
            }
        }

        static string NameUpper(Product p) {
            return p.Name.ToUpper();
        }
    }
}
