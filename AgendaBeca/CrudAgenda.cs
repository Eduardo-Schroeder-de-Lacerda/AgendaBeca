using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace AgendaBeca
{
    class CrudAgenda
    {
        public void HandleDiretorio()
        {
            string dirName = @"C:\Temp";
            string fileName = @"C:\Temp\agenda.txt";
            if (!Directory.Exists(dirName))
            {
                Directory.CreateDirectory(dirName);
            }
            if (!File.Exists(fileName))
            {
                File.Create(fileName);
            }

        }

        public void AdicionarPessoa()
        {
            string fileName = @"C:\Temp\agenda.txt";

            Console.WriteLine("Digite o nome da Pessoa: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Digite a idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Digite a altura de: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Pessoa pessoa = new Pessoa(nome, altura, idade);

            using (StreamWriter sw = File.AppendText(fileName))
            {
                sw.WriteLine(pessoa.DadosUsuario());
            }
            Console.WriteLine("Cadastrado com sucesso");
            Console.WriteLine(pessoa.DadosUsuario());
            Console.ReadLine();
        }

        public void BuscarPorNome()
        {
            Console.WriteLine("Digite o nome da Pessoa que deseja procurar");
            string username = Console.ReadLine();
            string fileName = @"C:\Temp\agenda.txt";

            string[] allLines = File.ReadAllLines(fileName);
            foreach (string line in allLines)
            {
                string[] splitedLine = line.Split(',');
                if (splitedLine[0] == $"Nome: {username}")
                {
                    string rightLine = line;
                    Console.WriteLine($"Pessoa encontrada:");
                    Console.WriteLine(rightLine);
                    Console.ReadLine();
                    return;
                }
            }
            Console.WriteLine("Pessoa não encontrada!");
            Console.ReadLine();
        }

        public void BuscarTodos()
        {
            string fileName = @"C:\Temp\agenda.txt";

            string[] allLines = File.ReadAllLines(fileName);
            foreach (string line in allLines)
            {
                Console.WriteLine(line);
            }
            Console.ReadLine();
        }

        public void RemoverPorNome()
        {
            Console.WriteLine("Digite o nome da Pessoa que quer remover");
            string username = Console.ReadLine();
            string fileName = @"C:\Temp\agenda.txt";
            Boolean encontrado = false;
            List<string> newLines = new List<string>();
            string[] allLines = File.ReadAllLines(fileName);
            foreach (string line in allLines)
            {
                string[] splitedLine = line.Split(',');
                if (splitedLine[0] == $"Nome: {username}")
                {
                    string rightLine = line;
                    Console.WriteLine($"Pessoa encontrada:");
                    Console.WriteLine(rightLine);

                    Console.ReadLine();
                    encontrado = true;
                }
                else
                {
                    newLines.Add(line);
                }
            }

            if (encontrado)
            {
                File.WriteAllText(fileName, String.Empty);

                using (StreamWriter sw = File.AppendText(fileName))
                {
                    foreach (string line in newLines)
                    {
                        sw.WriteLine(line);
                    }
                }
                Console.WriteLine("Pessoa excluida com sucesso!");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada!");
                Console.ReadLine();
            }
        }
    }
}

