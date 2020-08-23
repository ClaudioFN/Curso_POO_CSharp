using System;
using System.Linq;

namespace introducao_linq {
    class Program {
        static void Main(string[] args) {
            // Especificar a fonte de dados
            int [] numbers = new int[] { 2, 3, 4, 5 };

            // Definir a expressão da query 
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10);

            // Executar a query
            foreach (int x in result) {
                Console.WriteLine(x);
            }
        }
    }
}
