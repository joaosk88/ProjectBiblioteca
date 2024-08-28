using System;
using System.Collections.Generic;

namespace ProjectBiblioteca.Models
{
    public class Usuario
    {
        public string Nome { get; set; }
        public DateTime HoraDoEmprestimo { get; set; }
        public List<Livro> LivrosEmprestados { get; private set; }

        // Construtor da classe Usuario
        public Usuario()
        {
            HoraDoEmprestimo = DateTime.Now;
            LivrosEmprestados = new List<Livro>();
        }

        // Método para obter a hora do empréstimo
        public int GetHours()
        {
            return HoraDoEmprestimo.Hour;
        }

        public override string ToString()
        {
            string livrosEmprestados = LivrosEmprestados.Count > 0
                ? string.Join(", ", LivrosEmprestados)
                : "Nenhum livro emprestado";

            return $"Usuario: {Nome}, Data do empréstimo: {HoraDoEmprestimo}, Livros Emprestados: {livrosEmprestados}";
        }
    }
}
