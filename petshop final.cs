using Petshop_Console;

using System;

using System.Data;

using System.Runtime.CompilerServices;


public class Program

{

    public static void Main()

    {
        Animal[] animais = new Animal[2];
        int quantidade = 0;
        int escolha;
        int especie = 0;
       
       
        do

        {
            Console.WriteLine("Escolha a informação desejada");

            Console.WriteLine("1 - Cadastrar animal");

            Console.WriteLine("2 - Mostrar lista");

            Console.WriteLine("3 - Atendimento");

            Console.WriteLine("4 - Sair");

            escolha = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

         

            if (escolha == 1)
            {

                if (quantidade >= animais.Length)
                {
                    Console.WriteLine("Capacidade cheia.");
                    break;
                }
                    
                    Console.WriteLine("Escreva o nome do seu Aniemal: ");
                    string Nome = Console.ReadLine();

                    Console.WriteLine("Escreva a velhice do seu bischço: ");
                    int Idade = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Escolha a especie do animal: ");
                    Console.WriteLine("0 para Cachorro e 1 para Gato");
                    especie = Convert.ToInt32(Console.ReadLine());


                    if(especie == 0)
                    {
                        animais[quantidade++] = new Cachorro(Idade, Nome);
                    }
                    else if (especie == 1)
                    {
                        animais[quantidade++] = new Gato(Idade, Nome);
                    }

                Console.Clear();
                    
             }

            if (escolha == 2)
                
            {
                for (int i = 0; i < animais.Length; i++)

                {

                    Console.WriteLine($"{i} | Nome: {animais[i].GetNome()} | Idade: {animais[i].GetIdade()}|");

                }

            }

            if (escolha == 3)

            {                                           
                    Console.Write("\nDigite o nome do animal a ser atendido: ");
                    string nome = Console.ReadLine();
                    Animal atendimento = null;

                    for (int i = 0; i < animais.Length; i++) 
                    {
                        if (animais[i].GetNome() == nome)
                        {
                            atendimento = animais[i];
                            break;
                        }
                    }

                    if (atendimento != null)
                    {
                        atendimento.Comportamento();
                    }
                    else
                    {
                        Console.WriteLine("Animal não encontrado!");
                    }


                
            }
        } while (escolha != 4);



                }
               
                
            



        }

    





