namespace WebAPI.Models
{
    public class Tema
    {
        public int TemaId { get; set; }
        public string? Titulo { get; set; }
        public string? ImageUrl { get; set; }

        //Relacionamentos
        public int MateriaId { get; set; }
        public Materia? Materia { get; set; }
        public ICollection<Pergunta> Perguntas { get; set; } = new List<Pergunta>();
    }
}