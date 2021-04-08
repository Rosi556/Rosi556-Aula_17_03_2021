using System;

namespace Modelos{
    public class CarroIntermediario : Carro
    {
        public CarroIntermediario(String marca, String modelo, String placa, int ano): base(marca, modelo, placa, ano){
            this.velocidade = 180;
        }
        public override void Correr(){
            Console.WriteLine("Estou correndo normalmente ...");
        }
    }
}