using System;

namespace Modelos{
    public class CarroRapido : Carro
    {
        public CarroRapido(String marca, String modelo, String placa, int ano): base(marca, modelo, placa, ano){
            this.velocidade = 250;
        }

        public override void Correr(){
            Console.WriteLine("Estou voando ... Uhuu ...");
        }
    }
}