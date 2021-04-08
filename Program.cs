using System;
using System.Collections.Generic;
using Modelos;

namespace AULA_POO_NOITE
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ICorredor> elementos = new List<ICorredor>();
            Carro porsche = new CarroRapido("Porsche", "911 Carrera Turbo S", "PYL-8D99", 2021);
            elementos.Add(porsche);
            Carro gol = new CarroLento("Volkswagen", "Gol", "kkk-9999", 2008);
            elementos.Add(gol);

            Pessoa p = new Pessoa("Nilo", 18, 'M');
            elementos.Add(p);

            foreach(ICorredor e in elementos){
                e.Correr();
                if (e is Pessoa){
                    Pessoa pes = e as Pessoa;
                    Console.WriteLine($"Tenho {pes.Idade} anos de idade.");
                }
            }

            Console.ReadKey();
        }
    }
}
