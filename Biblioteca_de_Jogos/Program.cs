using System;
using System.Collections.Generic;

namespace Biblioteca_de_Jogos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jogo> listaDeJogos = new List<Jogo>();
            Console.ForegroundColor = ConsoleColor.Green;

            while (true)
            {
                Console.WriteLine("=====BIBLIOTECA DE JOGOS=====");

                Console.WriteLine("1 - Adicionar Jogo");
                Console.WriteLine("2 - Listar Jogos");
                Console.WriteLine("3 - Editar Jogo");
                Console.WriteLine("4 - Remover Jogo");
                Console.Write("Opção: ");

                bool resultado;
                String opcao = Console.ReadLine();

                switch(opcao)
                {
                    case "1":
                        resultado = AdicionarJogo(listaDeJogos);
                        if(resultado == true)
                        {
                            Console.WriteLine("Cadastrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Erro no cadastro.");
                        }
                        break;

                    

                }
            }
        }
    }
}
