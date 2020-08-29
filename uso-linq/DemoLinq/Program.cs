using System;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DemoLinq {
    class Program {

        static void Print<T>(string message, IEnumerable<T> collection) {
            Console.WriteLine(message);
            foreach(T obj in collection) {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }
        static void Main(string[] args) {

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2};
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> products = new List<Product>(){
                new Product() {Id = 1, Name = "Computer", Price = 110.0, Category = c2},
                new Product() {Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() {Id = 3, Name = "TV", Price = 1700.0, Category = c3},
                new Product() {Id = 4, Name = "Notebook", Price = 1300.0, Category = c2},
                new Product() {Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product() {Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product() {Id = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product() {Id = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product() {Id = 9, Name = "MacBook", Price = 1800.0, Category = c2},
                new Product() {Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product() {Id = 11, Name = "Lvel", Price = 70.0, Category = c1}
            };

            //Consultas com LINQ usando Lambda

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);
            Print("Tier 1 and Price < 900.00:", r1);

            var r1_2 = from p in products where p.Category.Tier == 1 && p.Price < 900.0 select p;
            Print("Tier 1 and Price < 900.00(C#SQL):", r1_2);

            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Products with names like tools:", r2);

            var r2_2 = from p in products where p.Category.Name == "Tools" select p.Name;
            Print("Products with names like tools(C#SQL):", r2_2);

            // CategoryName: alias para evitar ambiguidade
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });
            Print("Names starting with C and anonymous object: ", r3);

            var r3_2 = from p in products where p.Name[0] == 'C' select new { p.Name, p.Price, CategoryName = p.Category.Name };
            Print("Names starting with C and anonymous object(C#SQL): ", r3_2);

            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Tier 1 orded by Price and Name: ", r4);

            var r4_2 = from p in products where p.Category.Tier == 1 orderby p.Name orderby p.Price select p;
            Print("Tier 1 orded by Price and Name(C#SQL): ", r4_2);

            var r5 = r4.Skip(2).Take(4);
            Print("Orded by Price and Name selecting after 2 only 4: ", r5);

            var r5_2 = (from p in products select p).Skip(2).Take(4);
            Print("Orded by Price and Name selecting after 2 only 4(C#SQL): ", r5_2);

            var r6 = products.FirstOrDefault();
            Console.WriteLine("First pr default: " + r6);

            // Achar o máximo e mínino na coleção 
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("Max Price: " + r10);
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("Min Price: " + r11);

            // Instrução de soma
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Category 1 Sum Price: " + r12);

            // Instrução de soma personalizada via Aggregate(0.0 para dar valor inicial)
            var r13 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Category 1 Aggregate Sum: " + r13);

        }
    }
}
