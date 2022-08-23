using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_de_Jogos.Classes
{
    internal class Jogo
    {
        // ATRIBUTOS

        public String titulo;
        public String genero;
        public int ano;
        public int maxJogadores;
        public int metacritic;

        // CONSTRUTORES

        public Jogo (String titulo, int ano, String genero, int maxJogadores, int metacritic)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
            this.metacritic = metacritic; 
        }

        public Jogo(String titulo, int ano, String genero, int maxJogadores)
        {
            this.titulo = titulo;
            this.ano = ano;
            this.genero = genero;
            this.maxJogadores = maxJogadores;
        }

        // MÉTODOS DE ACESSO
        // GETTER - RETORNA VALOR DO ATRIBUTO

        public String getTitulo()
        {
            return this.titulo; 
        }

        public int getAno()
        {
            return this.ano;
        }

        public String getGenero()
        {
            return this.genero;
        }

        public int getMaxJogadores()
        {
            return this.maxJogadores;
        }

        public int getMetaCritic()
        {
            return this.metacritic;
        }

        // SETTER - MODIFICA VALOR DO ATRIBUTO

        public void setTitulo(String titulo)
        {
            if(titulo != "")
            {
                this.titulo = titulo;
            }
        }

        





    }
}
