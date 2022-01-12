using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using musicmvc.Models;

namespace musicmvc.Data
{
    public class MSContext : DbContext
    {
        public MSContext(DbContextOptions<MSContext> options) : base(options)
        {}
        public DbSet<Album>? Albums { get; set; }
        public DbSet<Genre>? Genres { get; set; }

        public DbSet<Artist>? Artists { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Album>().HasData(
                new Album{
                    AlbumId = 1,
                    GenreId=1,
                    ArtistId =1,
                    Title = "After Hours",
                    Price = 44.9,
                    AlbumArtUrl = "https://open.spotify.com/album/4yP0hdKOZPNshxUOjY0cZj",
                },
                new Album{
                    AlbumId = 2,
                    GenreId=2,
                    ArtistId =2,
                    Title = "30",
                    Price = 44.9,
                    AlbumArtUrl = "https://open.spotify.com/album/21jF5jlMtzo94wbxmJ18aa",
                },
                new Album{
                    AlbumId = 3,
                    GenreId=6,
                    ArtistId =3,
                    Title = "Tierra",
                    Price = 44.9,
                    AlbumArtUrl = "https://open.spotify.com/album/0RzCItg7w7kHuLjDnZBCfB",
                },
                new Album{
                    AlbumId = 4,
                    GenreId=2,
                    ArtistId =4,
                    Title = "Lemonade",
                    Price = 44.9,
                    AlbumArtUrl = "https://open.spotify.com/album/7dK54iZuOxXFarGhXwEXfF",
                },
                new Album{
                    AlbumId = 5,
                    GenreId=2,
                    ArtistId =5,
                    Title = "Everyday",
                    Price = 44.9,
                    AlbumArtUrl = "https://open.spotify.com/album/2FeyIYDDAQqcOJKOKhvHdr",
                }
            );
            modelBuilder.Entity<Genre>().HasData(
                 new Genre{
                    GenreId =1,
                    Name ="Hip Hop"
                },
                new Genre{
                    GenreId =2,
                    Name ="Pop"
                },
                new Genre{
                    GenreId =3,
                    Name ="Rock"
                },
                new Genre{
                    GenreId =4,
                    Name ="Eletrônica"
                },
                new Genre{
                    GenreId =5,
                    Name ="Blues"
                },
                new Genre{
                    GenreId=6,
                    Name="Clássico"
                }
            );
            modelBuilder.Entity<Artist>().HasData(
                new Artist{
                    ArtistId=1,
                    Nome = "The Weeknd"
                },
                 new Artist{
                    ArtistId=2,
                    Nome = "Adele"
                },
                 new Artist{
                    ArtistId=3,
                    Nome = "Tierre"
                },
                 new Artist{
                    ArtistId=4,
                    Nome = "Beyonce"
                },
                 new Artist{
                    ArtistId=5,
                    Nome = "Coldplay"
                }
            );   
        }
    }
}