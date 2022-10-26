using System.ComponentModel.DataAnnotations;
using e_tickey.Data;
using e_tickey.Data.Base;

namespace e_tickey.Models
{
    public class Cinema :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Cinema Logo")]
        public string Logo { get; set; } = String.Empty;
        [Display(Name ="cinema Name")]
        public string Name { get; set; } = String.Empty;
        [Display(Name ="Description")]
        public string Description { get; set; } = String.Empty;
        public MovieCategory MovieCategory { get; set; }

        //Relationships
        public List<Movie> Movies { get; set;} = new List<Movie>();

        
    }
}