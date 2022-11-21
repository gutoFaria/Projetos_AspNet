namespace Cardapio.Models
{
    public class Salada
    {
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string ImageUrl { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public double Price { get; set; }
        public int CategoriaId { get; set; }
    }
}