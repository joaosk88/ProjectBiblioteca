﻿namespace ProjectBiblioteca.Models
{
    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }
        public string Genero { get; set; }  

        public override string ToString()
        {
            return $"Título: {Titulo}, Autor: {Autor}, Editora: {Editora}, Genero: {Genero}";
        }
    }
}
