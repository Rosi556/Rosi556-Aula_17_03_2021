using System;

namespace Modelos{
    public class CarroLento : Carro
    {
        public CarroLento(String marca, String modelo, String placa, int ano): base(marca, modelo, placa, ano){
            this.velocidade = 120;
        }
        public override void Correr(){
            Console.WriteLine("Estou vagando lentamente ... Sono ...");
        }
    }
}