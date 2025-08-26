using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop_Console
{
    public class Cachorro : Animal
    {
        public override void Comportamento()
        {
            Console.WriteLine($"O {nome} acabou de latir");
        }


    }
}
