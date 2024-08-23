using System;
using ProjectBiblioteca.Models;
using ProjectBiblioteca.Src.Models.Usuario.ProjectBiblioteca.Models;

namespace ProjectBiblioteca
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Livro livro = new Livro
            {
                Titulo = "O Senhor dos Anéis",
                Autor = "J. R. R. Tolkien",
                Editora = "HarperCollins",
                Genero = "Fantasia",
            };

            Livro livro01 = new Livro01
            {
                Titulo = "Manifesto do partido comunista",
                Autor = "Karl Marx",
                Editora = "Camelot",
                Genero = "Politico",
            };



            // Criando uma instância de Usuario
            Usuario usuario = new Usuario("Maria da Silva");
            usuario.AdicionarLivroEmprestado(livro);
            Console.WriteLine(usuario);
        }
    }
}

