using ProjectBiblioteca.Models;

namespace TestsXUnit
{
    public class TestesLivro
    {
        [Fact]
        public void Teste_Instancia_De_Livro_Criando_Corretamente()
        {
            Livro livro = new Livro
            {
                Titulo = "O Senhor dos Anéis",
                Autor = "J. R. R. Tolkien",
                Editora = "HarperCollins",
                Genero = "Fantasia",
            };

            Assert.NotNull(livro);
        }

        [Fact]
        public void Teste_Valores_De_Livro_Conforme_Construcao()
        {
            string titulo = "O Senhor dos Anéis";
            string autor = "J. R. R. Tolkien";
            string editora = "HarperCollins";
            string genero = "Fantasia";

            Livro livro = new Livro
            {
                Titulo = titulo,
                Autor = autor,
                Editora = editora,
                Genero = genero,
            };

            Assert.Equal(titulo, livro.Titulo);
            Assert.Equal(autor, livro.Autor);
            Assert.Equal(editora, livro.Editora);
            Assert.Equal(genero, livro.Genero);
        }
    }
}