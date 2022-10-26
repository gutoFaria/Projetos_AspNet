using System.ComponentModel.DataAnnotations;
using e_tickey.Data.Base;

namespace e_tickey.Models
{
    public class Producer :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture URL")]
        public string ProfilePictureURL { get; set; } = String.Empty;
        [Display(Name ="Full Name")]
        public string FullName { get; set; } = String.Empty;
        [Display(Name ="Biografy")]
        public string Bio { get; set; } = String.Empty;

        //Relationships
        public List<Movie> Movies { get; set;} = new List<Movie>();

        
    }
}