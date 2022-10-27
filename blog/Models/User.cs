namespace blog.Models
{
    public class User : Entity
    {
        
       
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public User(Guid id):base(id){}
        public User(Guid id,string name,string email,string password) : base(id)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        
    }
}