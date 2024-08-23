using System;
using System.Collections.Generic;
using ProjectBiblioteca.Models;

namespace ProjectBiblioteca
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Livro livro1 = new Livro
            {
                Titulo = "O Senhor dos Anéis",
                Autor = "J. R. R. Tolkien",
                Editora = "HarperCollins",
                Genero = "Fantasia"
            };

            Livro livro2 = new Livro
            {
                Titulo = "Manifesto do Partido Comunista",
                Autor = "Karl Marx e Friedrich Engels",
                Editora = "Camelot",
                Genero = "Político"
            };

            Livro livro3 = new Livro
            {
                Titulo = "Novela de um Luto",
                Autor = "Noemi Jaffe",
                Editora = "Campanha das Letras",
                Genero = "Autoajuda"
            };

            List<Livro> livros = new List<Livro> { livro1, livro2, livro3 };

            Usuario usuario = new Usuario
            {
                Nome = "Claudinei"
            };

            foreach (var livro in livros)
            {
                Console.WriteLine(livro);
            }

            // Exibindo informações sobre o empréstimo
            Console.WriteLine($"Empréstimo solicitado por: {usuario.Nome}");
            Console.WriteLine($"Livro emprestado: {livro1}");
        }
    }
}