using System;
using Extensions;

namespace uso_extension_methods {
    class Program {
        static void Main(string[] args) {
            // DateTime dt = new DateTime(2018, 11, 16, 8, 10, 45);
            // Console.WriteLine(dt.ElapsedTime()); // Esse ElapsedTime é chamado pelo fato de estar usando o 'using Extensions'

            string s1 = "Good Morning Dear Students!";
            Console.WriteLine(s1.Cut(10));
        }
    }
}
