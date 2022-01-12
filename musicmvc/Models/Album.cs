using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace musicmvc.Models
{
    public class Album
    {
        [Key]
        public int AlbumId { get; set; }
        [ForeignKey("GenreId")]
        public int GenreId { get; set; }
        [ForeignKey("ArtistId")]
        public int ArtistId { get; set; }
        public string? Title { get; set; }
        public double Price { get; set; }
        public string? AlbumArtUrl { get; set; }
        public Genre? Genre { get; set; }
        public Artist? Artist { get; set; }
    }
}