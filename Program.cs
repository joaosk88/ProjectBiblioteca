internal class Program
{
    using System;
using MyLibraryProject.Models;

namespace MyLibraryProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ProjectBiblioteca projectBiblioteca = new ProjectBiblioteca
            {
                Titulo = "O Senhor dos Anéis",
                Genero = "Ficção",
                Editor = "Imfe",
                Autor = "Tolkien"
            };

            Console.WriteLine(projectBiblioteca);
        }
    }
}

        
}