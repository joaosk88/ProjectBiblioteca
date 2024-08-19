namespace MyLibraryProject.Models
{
    public class ProjectBiblioteca
    {
        public string Titulo { get; set; }
        public string Genero { get; set; }
        public string Editor { get; set; }
        public string Autor { get; set; }

        public override string ToString()
        {
            return $"Titulo: {Titulo}, Gênero: {Genero}, Editor: {Editor}, Autor: {Autor}";
        }
    }
}
