using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca_de_Jogos
{
    internal class Jogo
    {
        // ATRIBUTOS

        String titulo;
        String genero;
        int ano;
        int maxJogadores;
        int metacritic;

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

        // SETTER - MODIFICA VALOR DO ATRIBUTO

        public void setTitulo(String titulo)
        {
            if(titulo != "")
            {
                this.titulo = titulo;
            }
        }

        public int getAno()
        {
            return this.ano;
        }





    }
}
