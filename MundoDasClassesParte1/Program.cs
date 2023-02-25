using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDasClassesParte1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro(Cor.Branco, 4, "Camaro"); //cria carro
            Console.WriteLine("O carro é um "+carro.Modelo+" de cor "+carro.Cor+" e tem "+carro.Portas+" portas.");
            Console.WriteLine(carro.Ligar()); //ligar carro
            Console.WriteLine("Ligado? " + carro.Ligado);
            Console.WriteLine(carro.Andar()); // Andar com o carro
            Console.WriteLine(carro.Desligar());
            Console.WriteLine("Ligado? " + carro.Ligado);
            carro.Cor = Cor.Azul; //Pintando o carro de azul
            Console.WriteLine("A nova cor do carro é " + carro.Cor);
        }
    }
}
