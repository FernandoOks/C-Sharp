using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoDasClassesParte2
{
    internal class Gato : Animal
    {
        public Gato(string nome, int idade) : base(nome, idade) //base(nome, idade) invoca o construtor da classe Animal
        {

        }
    }
}
