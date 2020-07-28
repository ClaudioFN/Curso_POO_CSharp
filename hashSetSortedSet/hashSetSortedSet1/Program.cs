using System;
using System.Collections.Generic;
using Entities;


namespace hashSetSortedSet1 {
    class Program {
        /*static void Main(string[] args) {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            foreach (string p in set) {
                Console.WriteLine("Values: " + p);
            }

            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };
            PrintCollection(a);

            // Union - Juntar os dois conjuntos sem repitir números
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            // Intersection - Mantém os elementos que são iguais em ambos 
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            // Difference - Mostra os elementos que existem no item 1 mas não no item 2
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }
        static void PrintCollection<T>(IEnumerable<T> collection) {
            foreach (T obj in collection) {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }*/
        static void Main(string[] args) {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p)); // Comparação por conteúdo e não por referência
        }
    }
}
