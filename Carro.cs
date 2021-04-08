using System;

namespace Modelos{
    public abstract class Carro : ICorredor{
        protected int velocidade;
        private String marca;
        public String Marca{
            get
            {
                return marca;
            }
            set
            {
                this.marca = value.ToUpper();
            }
        }
        private String modelo;
        public String Modelo{ get=> modelo; set=> modelo= value.ToUpper();}
        public String Placa {get;set;} 
        public int Ano {get;set;}
        public Carro(){
            Console.WriteLine("Criando carro ...");
        }
        public Carro(String marca, String modelo) : this(){
            Marca = marca;
            Modelo = modelo;
        }
        public Carro(String marca, String modelo, String placa, int ano) : this(marca, modelo){
            Placa = placa;
            Ano = ano;
        }
        public abstract void Correr();
        public void Correr(Carro c){
            Console.WriteLine($"Correndo contra {c.Marca} {c.Modelo} ...");
            Correr();
        }
    }
}