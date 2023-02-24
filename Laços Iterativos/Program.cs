using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços_Iterativos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Laço iterativos => estruturas que repetem um bloco de código, determinado numero de vezes.

            //Laço For
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Valor de i é " + i);
            }

            //While
            int contador = 3;
            while (contador <10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            //Do ...While
            double j = 10;
            do //execução garantida pelo menos uma vez. Executa o bloco e depois testa.
            {
                Console.WriteLine(j);
                j = j * 1.5;
            } while (j < 100);

            //Foreach
            //Percorre todos os elementos do conjunto.
            int[] conjunto = { 1, 2, 3, 7 };
            foreach(int numero in conjunto)
            {
                Console.WriteLine("Esse elemento do conjunto tem o valor " + numero + "! Somando esse valor a 10 temos " + (numero+10));
            }
        }
    }
}
