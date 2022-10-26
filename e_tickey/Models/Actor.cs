using System.ComponentModel.DataAnnotations;
using e_tickey.Data.Base;

namespace e_tickey.Models
{
    public class Actor :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture URL")]
        [Required(ErrorMessage ="is required")]
        public string ProfilePictureURL { get; set; } = String.Empty;
        [Display(Name ="Full Name")]
        [Required(ErrorMessage ="is required")]
        public string FullName { get; set; } = String.Empty;
        [Display(Name ="Biografy")]
        [Required(ErrorMessage ="is required")]
        public string Bio { get; set; } = String.Empty;

        //Relationships
        public List<ActorMovie> ActorMovies { get; set; } = new List<ActorMovie>();
    }
}