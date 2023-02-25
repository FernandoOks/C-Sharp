using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MundoDasClassesParte2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Cachorro("Mumm-ra", 5);
            var g = new Gato("Lion",3);

            Animal a = new Gato("Cheetara", 4); //Polimorfismo: o gato também é um animal

            ExibeAminal(c); //recebe argumento do tipo Cachorro
            ExibeAminal(g); //recebe argumento do tipo Gato
            ExibeAminal(a); //recebe argumento do tipo Animal
        }

        public static void ExibeAminal(Animal animal)
        {
            Console.WriteLine($"Nome: {animal.Nome}");
            Console.WriteLine($"Idade: {animal.Idade}");
        }
    }
}
