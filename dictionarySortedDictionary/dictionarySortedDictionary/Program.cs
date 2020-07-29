using System;
using System.Collections.Generic;

namespace dictionarySortedDictionary {
    class Program {
        static void Main(string[] args) {
            Dictionary<string, string> cookies = new Dictionary<string, string>(); // Não admite repetições de chaves por mais que os valore sejam diferentes

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "99712234";
            cookies["phone"] = "83737388";

            Console.WriteLine(cookies["phone"]);
            cookies.Remove("email");

            if (cookies.ContainsKey("email")) {
                Console.WriteLine(cookies["email"]);
            }
            else {
                Console.WriteLine("There is no 'email' key in the collection!");
            }

            Console.WriteLine("Show all cookies: ");

            foreach(KeyValuePair<string, string> item in cookies) {// Dá pra usar 'var' no lugar do KeyValuePair
                Console.WriteLine("Key: " + item.Key + " - " + item.Value);
            }

        }
    }
}
