using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop_Console
{
    class Animal
    {
        private string Nome;
        public int especie;
        private int Idade;

        public Animal (int Nova_idade, string Novo_nome)
        {
            SetIdade(Nova_idade);
            SetNome(Novo_nome);
        }   


        public void SetNome(string Novo_nome)
        {
            if (Novo_nome == null)
            {
                Console.WriteLine("Nome invalido");
            }
            else
            {
                Nome = Novo_nome;
            }
        }
        public string GetNome()
        {
            return Nome;
        }

        public void SetIdade(int Nova_idade)
        {
            if (Nova_idade <= 0)
            {
                Console.WriteLine("Idade invalida");
            }
            else
            {
                Idade = Nova_idade;
            }

        }
        public int GetIdade()
        {
            return Idade;
        }



        public virtual void Comportamento()
        {
            Console.WriteLine($"Sem comportamento");

        }

        
    }
}