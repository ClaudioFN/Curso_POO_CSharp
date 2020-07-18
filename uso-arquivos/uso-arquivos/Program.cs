using System;
using System.IO;
using System.Collections.Generic;

namespace uso_arquivos {
    class Program {
        /* Aula 1 - 186
        *  FileInfo - Função de Cópia(CopyTo) que não permite sobrescrita
        *  File - Ler conteúdo de arquivo(ReadAllLines)
        
        static void Main(string[] args) {
            string sourcePath = @"C:\temp\file1.txt"; // Origem
            string targetPath = @"C:\temp\file2.txt"; // Destino onde ainda não existe o arquivo
            try {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath); // Faz a cópia do arquivo
                string[] lines = File.ReadAllLines(sourcePath); // Ler linhas do arquivo selecionado
                int i = 0;
                foreach(string line in lines) {
                    Console.WriteLine("Linha " + ++i + " - " + line);
                }
            }catch(IOException e) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
        */

        /* Aula 2 - 187
        *  FileStream - Cria instância aberta do arquivo para uso
        *  StreamReader - Lê o arquivo aberto no FileStream
        
        static void Main(string[] args) {
            string path = @"C:\temp\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try {
                fs = new FileStream(path, FileMode.Open); // Abrir o arquivo
                sr = new StreamReader(fs); // Instância para leitura
                string line;
                while (!sr.EndOfStream) { // Loop de leitura
                    line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }catch(IOException e) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            finally {
                if (sr != null ) sr.Close();
                if (fs != null) fs.Close();
            } 
        }
        */

        /* Aula 3 - 188
        *  Bloco Using - Serve para dispensar o uso de Close() quando se conclui o uso de um arquivo

        static void Main(string[] args) {
            string path = @"C:\temp\file1.txt";
            try {
                //using (FileStream fs = new FileStream(path, FileMode.Open)) { // Bloco Duplo para uso do FileStream
                //    using (StreamReader sr = new StreamReader(fs)) {
                //        while (!sr.EndOfStream) {
                //            Console.WriteLine(sr.ReadLine());
                //        }
                //    }
                //}
                 using (StreamReader sr = File.OpenText(path)) { // Bloco Único para uso apenas do StreamReader
                     while (!sr.EndOfStream) {
                         Console.WriteLine(sr.ReadLine());
                     }
                 }
            }
            catch (IOException e) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
        */

        /* Aula 4 - 189
        *  StreamWriter - Para escrever em arquivos 
        
        static void Main(string[] args) {
            string sourcePath = @"C:\temp\file1.txt";
            string targetPath = @"C:\temp\file2.txt";

            try {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath)) { // AppendText instância um StreamWriter e escreve em um arquivo
                    foreach(string line in lines) {
                        sw.WriteLine("");
                        sw.WriteLine(line.ToUpper());
                        sw.WriteLine("Texto");
                    }
                }
            }catch(IOException e) {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }

        }
        */

        /* Aula 5 - 190
        *  Directory - Leitura de pastas do diretório, leitura de arquivos do diretório e criação de pastas
        
        static void Main(string[] args) {
            string path = @"C:\temp";

            try {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories); // Diretórios 
                Console.WriteLine("FOLDERS: ");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories); // Arquivos
                Console.WriteLine("FILES: ");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "\\new_folder"); // Criar pasta
            }
            catch(IOException e) {
                Console.WriteLine("An error has occurred");
                Console.WriteLine(e.Message);
            }
        }
        */

        /* Aula 6 - 191
        *  Path
        */
        static void Main(string[] args) {
            string path = @"C:\Users\claudio\Documents\Mobizen\file1.txt";

            Console.WriteLine("GetDirectoryName : " + Path.GetDirectoryName(path));

        }
    }
}
