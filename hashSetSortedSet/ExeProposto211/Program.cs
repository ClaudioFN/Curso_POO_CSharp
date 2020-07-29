using System;
using System.IO;
using Entities;
using System.Collections.Generic;

namespace ExeProposto211 {
    class Program {
        static void Main(string[] args) {

            HashSet<LogRecord> set = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string[] line = sr.ReadLine().Split(" ");

                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        set.Add(new LogRecord { Username = name, Instant = instant });
                        
                    }
                    foreach (LogRecord l in set) {
                        Console.WriteLine("User added to the users log: " + l.Username + "\nTime: " + l.Instant);
                    }
                    Console.WriteLine();
                    Console.WriteLine("Total User: " + set.Count);
                }
            }catch(IOException e) {
                Console.WriteLine("Erro: " + e.Message);
            }

        }
    }
}
