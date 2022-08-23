using Biblioteca_de_Jogos.Classes;
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

                    case "2":
                        resultado = ListarJogos(listaDeJogos);
                        if(resultado == true)
                        {
                            Console.WriteLine("Listado com sucesso!!");
                        }
                        else
                        {
                            Console.WriteLine("Erro na listagem, tente novamente!");
                        }
                        break;

                    case "3":
                        resultado = EditarJogos(listaDeJogos);
                        break;

                    case "4":
                        resultado = DeletarJogos(listaDeJogos);
                        break;

                    default:
                        Console.WriteLine("Opcão inválida.");
                        break;
                }

                Console.WriteLine("Pressione qualquer tecla pra continuar...");
                Console.ReadLine();
                Console.Clear();

            }
        }

        public static bool AdicionarJogo(List<Jogo> listaDejogos)
        {
            Console.Clear();
            Console.Write("Título: ");
            String titulo = Console.ReadLine();
            Console.Write("Ano: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gênero: ");
            String genero = Console.ReadLine();
            Console.Write("Número máximo de players: ");
            int maxJogadores = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nota no metacritic: ");
            int metacritic = Convert.ToInt32(Console.ReadLine());

            if (titulo == "")
            {
                return false;
            }

            if (ano < 1950)
            {
                return false;
            }

            if(maxJogadores > 4)
            {
                return false;
            }

            if(metacritic < 0 || metacritic >100) 
            {
                return false; 
            }

            Jogo novoJogo = new Jogo(titulo, ano, genero, maxJogadores, metacritic);

            listaDejogos.Add(novoJogo);
            Console.Beep();

            return true;
        }

        public static bool ListarJogos (List<Jogo> listaJogos)
        {
            foreach(Jogo jogo in listaJogos)
            {
                Console.Write("Titulo: ");
                Console.WriteLine(jogo.getTitulo());
                Console.Write("Ano: ");
                Console.WriteLine(jogo.getAno());
                Console.Write("Gênero: ");
                Console.WriteLine(jogo.getGenero());
                Console.Write("Máximo de players: ");
                Console.WriteLine(jogo.getMaxJogadores());
                Console.Write("Nota no metacritic: ");
                Console.WriteLine(jogo.getMetaCritic());
                Console.WriteLine("=========");
                Console.WriteLine("");
            }

            return true;
        }

        public static bool EditarJogos(List<Jogo> listaJogos)
        {
            Console.Clear();
            Console.Write("Escolha o nome do jogo para ser editado: ");
            String pesquisar_titulo = Console.ReadLine();
            foreach (Jogo jogo in listaJogos)
            {
                if(pesquisar_titulo == jogo.getTitulo())
                {
                    Console.Clear();
                    Console.Write("Novo título: ");
                    String novo_titulo = Console.ReadLine();
                    jogo.titulo = novo_titulo;

                    Console.Write("Novo Ano: ");
                    int novo_ano = Convert.ToInt32(Console.ReadLine());
                    jogo.ano = novo_ano;

                    Console.Write("Novo gênero: ");
                    String novo_genero = Console.ReadLine();
                    jogo.genero = novo_genero;

                    Console.Write("Novo máximo de jogadores: ");
                    int novo_maxJogadores = Convert.ToInt32(Console.ReadLine());
                    jogo.maxJogadores = novo_maxJogadores;

                    Console.Write("Nova nota no metacritic: ");
                    int novo_metacritic = Convert.ToInt32(Console.ReadLine());
                    jogo.metacritic = novo_metacritic;
                }
            }

            return true;
        }

        public static bool DeletarJogos(List<Jogo> listaJogos)
        {
            Console.Clear();
            Console.Write("Escolha o jogo para ser deletado: ");
            String buscar_titulo = Console.ReadLine();
            foreach (Jogo jogo in listaJogos)
            {
                if (buscar_titulo == jogo.getTitulo())
                {
                    listaJogos.Remove(jogo);
                    break;
                }

            }
            return true;
        }


    }
}
