using System;
using ProjectBiblioteca.Models;  

namespace ProjectBiblioteca
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Livro livro = new Livro
            {
                Titulo = "O Senhor dos Anéis",
                Autor = "Tolkien",
                Editora = "Imfe",
                Genero = "Ficção"
            };

            Console.WriteLine(livro);
        }
    }
}

