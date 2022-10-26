using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using e_tickey.Data;
using e_tickey.Data.Base;

namespace e_tickey.Models
{
    public class Movie :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Description { get; set; } = String.Empty;
        public double Price { get; set; }
        public string ImageURl { get; set; } = String.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; } 
        public int MyProperty { get; set; }
         public MovieCategory MovieCategory { get; set; }
        //Relationships
        public List<ActorMovie> ActorMovies { get; set; } = new List<ActorMovie>();

        //Cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaId")]
        public Cinema Cinema { get; set; } = new Cinema();

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; } = new Producer();
    }
}