using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tipos_e_Variáveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 10; //declara variavei e armazena nela
            int numero2 = 20;
            var soma = numero1 + numero2; //var define dinamicamente o tipo da variavel
            Console.WriteLine("A resultado é: " + soma);

            int copiaDenumero1 = numero1; // copia o valor da variavel numero1
            copiaDenumero1 = 11; //Valor alterado para 11;
            Console.WriteLine(numero1);
            Console.WriteLine(copiaDenumero1);

            var quadrado1 = new Quadrado(); //instancia o quadrado
            quadrado1.lado = 10; //quandrado1 terá o valor de lado = 10;
            var quadrado2 = quadrado1;
            quadrado2.lado = 11;
            Console.WriteLine(quadrado1.lado);
            Console.WriteLine(quadrado2.lado);
        }
        class Quadrado //define class chamada Quadrado
        {
            public int lado;//define um atributo inteiro, na classe Quadrado
        }
    }
}
