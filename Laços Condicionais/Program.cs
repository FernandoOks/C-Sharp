using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laços_Condicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Laços Condicionais => Execução mediante determinada condição/situação.
            //Laço if e else
            int hora = 18;
            if (hora <= 15) //se a hora for mais ou igual a 15, será impressa a mensagem;
                Console.Write("São menos que 15h. ");
            else if (hora <= 17)
                Console.WriteLine("A hora é menor ou igual a 17! ");
            else // o else garante a execução do bloco de codigo seguinte.
            {
                if (hora == 18)
                    Console.WriteLine("São 18h!");
                else
                    Console.WriteLine("`Já passou das 18h");
            }
            
            //Switch
            switch(hora)
            {
                case 15: //o teste condincional é exata
                    Console.WriteLine("São 15h");
                    break;
                case 18: 
                    Console.WriteLine("São 18h");
                    break;
            }                                 

            PrimeiroSemestre mes = PrimeiroSemestre.Maio;
            switch(mes)
            {
                case PrimeiroSemestre.Janeiro:
                    Console.WriteLine("Estamos em Janeiro");
                    break;
                case PrimeiroSemestre.Fevereiro:
                    Console.WriteLine("Estamos em Fevereiro");
                    break;
                case PrimeiroSemestre.Março:
                    Console.WriteLine("Estamos em Março");
                    break;
                case PrimeiroSemestre.Abril:
                    Console.WriteLine("Estamos em Abril");
                    break;
                case PrimeiroSemestre.Maio:
                    Console.WriteLine("Estamos em Maio");
                    break;
                case PrimeiroSemestre.Junho:
                    Console.WriteLine("Estamos em Junho");
                    break;
            }
        }
    }
}

public enum PrimeiroSemestre
{
    Janeiro, Fevereiro, Março, Abril, Maio, Junho
}