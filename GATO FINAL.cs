using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop_Console
{
     class Gato : Animal
    {
        public Gato(int Nova_idade, string Novo_nome) : base(Nova_idade, Novo_nome) { }
        public override void Comportamento()
        {
            Console.WriteLine($"O gato n quer mais miar");
        }
    }
}
