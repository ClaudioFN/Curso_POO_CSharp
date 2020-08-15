using System;

namespace uso_delegates {

    // Delegate: type safety de declaracoes
    delegate double BinaryNumericOperation(double n1, double n2); // O delegate deve ser declarado seguindo a mesma logica de parametrizacao que o metodo referenciado
    class Program {
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

        
    }
}
