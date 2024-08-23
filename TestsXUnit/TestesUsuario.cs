using ProjectBiblioteca.Models;


namespace TestsXUnit
{
    public class TestesUsuario
    {
        [Fact]
        public void Teste_Instancia_De_Usuario_Criando_Corretamente()
        {
            Usuario usuario = new Usuario
            {
                Nome = "Claudinei",
            };

            Assert.NotNull(usuario);
        }

        [Fact]
        public void Teste_Valores_De_Usuario_Conforme_Construcao()
        {
            string nome = "Claudinei";

            Usuario usuario = new Usuario
            {
                Nome = nome,
            };

            Assert.Equal(nome, usuario.Nome);
        }
    }
}