using Petshop_Console;
using System;
using System.Data;
using System.Runtime.CompilerServices;


public class Program
{

    public static void Main()
    {
        int escolha; 
       
           
        do
        {
            Console.WriteLine("Escolha a informação desejada");
            Console.WriteLine("1 - Cadastrar animal");
            Console.WriteLine("2 - Mostrar lista");
            Console.WriteLine("3 - Atendimento");
            Console.WriteLine("4 - Sair");
            escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Animal[] atendimento = new Animal[2];
            if (escolha == 1) {
               
               
                    for (int i = 0; i < atendimento.Length; i++)
                    {
                        atendimento[i] = new Animal();
                        Console.WriteLine("Escreva a espécie do seu petizin: ");
                        atendimento[i].especie = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Escreva o nome do seu Aniemal: ");
                        atendimento[i].nome = Convert.ToString(Console.ReadLine());

                        Console.WriteLine("Escreva a velhice do seu bischço: ");
                        atendimento[i].idade = Convert.ToDouble(Console.ReadLine());
                        Console.Clear();

                        

                                   }
                
               
                
            }
                Console.WriteLine("Escolha a informação desejada");
                Console.WriteLine("1 - Cadastrar animal");
                Console.WriteLine("2 - Mostrar lista");
                Console.WriteLine("3 - Atendimento");
                Console.WriteLine("4 - Sair");
                escolha = Convert.ToInt32(Console.ReadLine());
                

             if (escolha == 2)
            {
                for (int i = 0; i < atendimento.Length; i++)
                {
                   Console.WriteLine($"{i} - Especie: {atendimento[i].especie} | Nome: {atendimento[i].nome} | Idade: {atendimento[i].idade}");

                }
            }

            Console.WriteLine("Escolha a informação desejada");
            Console.WriteLine("1 - Cadastrar animal");
            Console.WriteLine("2 - Mostrar lista");
            Console.WriteLine("3 - Atendimento");
            Console.WriteLine("4 - Sair");
            escolha = Convert.ToInt32(Console.ReadLine());



            if (escolha == 3)
            {
                Console.WriteLine("Indice iniciando");
                Console.Clear();
            for (int i = 0; i < atendimento.Length; i++)
                    {
                        Console.WriteLine($"{i} - Especie: {atendimento[i].especie} | Nome: {atendimento[i].nome} | Idade: {atendimento[i].idade}");

                    }
                
                Console.WriteLine("Escolha indice: ");
                int indice = Convert.ToInt16(Console.ReadLine());


                if (atendimento[i].especie == "Cachorro")
               {
                    Console.WriteLine($"{i} o animal acabou de latir")
                
                else 
                {
                        Console.WriteLine($"{i} o animal acabou de miar")
                }
            }
            Console.WriteLine("Escolha a informação desejada");
            Console.WriteLine("1 - Cadastrar animal");
            Console.WriteLine("2 - Mostrar lista");
            Console.WriteLine("3 - Atendimento");
            Console.WriteLine("4 - Sair");
            escolha = Convert.ToInt32(Console.ReadLine());




        } while (escolha > 4);

    }




}

