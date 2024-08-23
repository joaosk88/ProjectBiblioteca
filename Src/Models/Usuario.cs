using ProjectBiblioteca.Models;

namespace ProjectBiblioteca.Models
{
    public class Usuario
    {
        
        public string Nome { get; set; }

     
        public override string ToString()
        {
            return $"Usuario: {Nome}";
        }
    }
}
