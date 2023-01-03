namespace WebAPI.Models
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public string? Titulo { get; set; }
        public string? ImageUrl { get; set; }

        //Relacionamentos
        public ICollection<Tema> Temas { get; set;} = new List<Tema>();
    }
}