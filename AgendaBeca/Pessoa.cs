using System.Globalization;

namespace AgendaBeca
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public double Altura { get; set; }
        public int Idade { get; set; }

        public Pessoa(string nome, double altura, int idade)
        {
            Nome = nome;
            Altura = altura;
            Idade = idade;
        }

        public string DadosUsuario()
        {
            return $"Nome: {Nome}, " +
                   $"Idade: {Idade}, " +
                   $"Altura: {Altura.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}