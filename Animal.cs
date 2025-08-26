using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop_Console
{
    public class Animal
    {
        public string nome;
        private string especie {get; set;}

        public double idade;

     


        public virtual void Comportamento()
        {
            Console.WriteLine($"Sem comportamento");

        }

       

        public virtual void ValidarIdade()
        {

            if (idade <= 0)
            {
                Console.WriteLine("Idade não válida");
            }
        }
    }
}