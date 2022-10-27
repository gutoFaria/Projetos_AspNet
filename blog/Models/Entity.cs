namespace blog.Models
{
    public class Entity
    {
        //apenas o construtor insere
        public Guid Id { get; private set; }
        public Entity(Guid id)
        {
            Id = id; 
        }
    }
}