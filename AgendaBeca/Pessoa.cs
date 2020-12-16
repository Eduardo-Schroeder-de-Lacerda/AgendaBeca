using System;
using System.Globalization;

namespace AgendaBeca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public double Altura { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, double altura, DateTime dataNascimneto, int idade)
        {
            Nome = nome;
            Altura = altura;
            DataNascimento = dataNascimneto;
            Idade = idade;
        }

        public string DadosUsuario()
        {
            return $"Nome: {Nome}, " +
                   $"Data de Nascimento: {DataNascimento.ToString("dd/MM/yyyy")}, " +
                   $"Idade: {Idade}, " +
                   $"Altura: {Altura.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}