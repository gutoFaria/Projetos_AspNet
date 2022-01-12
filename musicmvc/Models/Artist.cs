using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace musicmvc.Models
{
    public class Artist
    {
        [Key]
        public int ArtistId { get; set; }
        public string? Nome { get; set; }
    }
}