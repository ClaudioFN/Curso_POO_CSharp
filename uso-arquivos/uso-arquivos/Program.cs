using System;
using System.IO;

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
        static void Main(string[] args) {
            string path = @"C:\temp\file1.txt";
            
        }
    }
}
