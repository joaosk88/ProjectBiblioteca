using System;
using System.Collections.Generic;
using ProjectBiblioteca.Models;

namespace ProjectBiblioteca
{
    internal class Program
    {
        public static object LivrosEmprestados { get; private set; }

        private static void Main(string[] args)
        {
            // Criando instâncias de livros
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

            // Criando instância de usuário
            Usuario usuario = new Usuario
            {
                Nome = "Claudinei"
            };

            // Adicionando livros à lista de livros emprestados do usuário
            usuario.LivrosEmprestados.Add(livro1);
            usuario.LivrosEmprestados.Add(livro2);
            usuario.LivrosEmprestados.Add(livro3);

            // Exibindo informações sobre o empréstimo
            Console.WriteLine($"Usuario: {usuario.Nome}");
            Console.WriteLine($"Hora do empréstimo: {usuario.HoraDoEmprestimo}");
            Console.WriteLine($"Livros emprestados:{LivrosEmprestados}");

            // Exibindo a lista de livros emprestados
            foreach (var livro in usuario.LivrosEmprestados)
            {
                Console.WriteLine($"- {livro.Titulo} por {livro.Autor}");
            }
        }
    }
}
