using System;

namespace ExemploThis
{
    class Pessoa
    {
        // Atributos
        private string nome;
        private int idade;

        // Uso do this para diferenciar atributo de parâmetro
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        // Construtor chamando outro construtor com this
        public Pessoa(string nome) : this(nome, 0)
        {
        }

        // Método usando this para deixar explícito
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {this.nome}, Idade: {this.idade}");
        }

        // Passando o próprio objeto como parâmetro
        public void MostrarDados()
        {
            ExibirPessoa(this);
        }

        private void ExibirPessoa(Pessoa p)
        {
            Console.WriteLine($"[ExibirPessoa] Nome: {p.nome}, Idade: {p.idade}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Davi", 17);
            Pessoa p2 = new Pessoa("Cupixa");

            p1.Apresentar();
            p2.Apresentar();

            p1.MostrarDados();
        }
    }
}

