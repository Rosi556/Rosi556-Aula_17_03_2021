using System;
namespace Modelos{
    public class Pessoa : ICorredor
    {
        private string nome;
        public string Nome {get => nome; set => nome = value;}
        private int idade;
        public int Idade {get => idade; set => idade = value;}
        private char genero;
        public Pessoa(string nome, int idade, char genero){
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }

        public void Correr(){
            Console.WriteLine($"Olá, me chamo {Nome} e estou correndo ...");
        }
    }
}