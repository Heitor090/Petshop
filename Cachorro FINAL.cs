using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop_Console
{
    class Cachorro : Animal
    {
        public Cachorro( int Nova_idade, string Novo_nome) : base( Nova_idade, Novo_nome) { }
        public override void Comportamento()
        {
            Console.WriteLine($"O cachorro nao aguenta mais latir");
        }


    }
}
