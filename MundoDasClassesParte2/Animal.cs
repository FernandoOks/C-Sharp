using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MundoDasClassesParte2
{
    public abstract class Animal //uma classe abstrata não pode ser instanciada
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public abstract Som SomEmitido { get; } //Essa propriedade devera ser implementada por cada classe filha, já que é abstrata.
        public virtual string Locomocao { get { return "Está andando"; } }//Essa propriedade poderá ou não ser sobreescrita nas classes filhas.

        public Animal(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
    }
}
