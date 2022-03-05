using ListaAnime.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaAnime.Data
{
    public static class SeedData
    {
        public static void SeedDatabase(AppDbContext context)
        {
            context.Database.Migrate();

            if(context.Mangas.Count() == 0 && context.Autores.Count() == 0 && context.Generos.Count() == 0)
            {
                Autor a1 = new Autor {NomeAutor = "Eiichiro Oda"};
                Autor a2 = new Autor {NomeAutor = "Masashi Kishimoto"};
                Autor a3 = new Autor {NomeAutor = "Yoshihiro Togashi"};
                Autor a4 = new Autor {NomeAutor = "Maruyama Kugane"};
                Autor a5 = new Autor {NomeAutor = "TurtleMe"};
                Autor a6 = new Autor {NomeAutor = "Black Ajin"};
                Autor a7 = new Autor {NomeAutor = "Harold Sakuishi"};
                Autor a8 = new Autor {NomeAutor = "Tabata Yuuki"};

                context.Autores.AddRange(a1,a2,a3,a4);
                context.SaveChanges();

                Genero g1 = new Genero { NomeGenero = "Aventura"};
                Genero g2 = new Genero { NomeGenero = "Ação"};
                Genero g3 = new Genero { NomeGenero = "Fantasia"};
                Genero g4 = new Genero { NomeGenero = "Artes Marcias"};
                Genero g5 = new Genero { NomeGenero = "Musical"};

                context.Generos.AddRange(g1,g2,g3);

                Manga m1 = new Manga {NomeManga = "One Piece",Autor = a1,Genero = g1};
                Manga m2 = new Manga {NomeManga = "Naruto",Autor = a2,Genero = g1};
                Manga m3 = new Manga {NomeManga = "Yu Yu Hakusho ",Autor = a3,Genero = g2};
                Manga m4 = new Manga {NomeManga = "Hunter x Hunter",Autor = a3,Genero = g2};
                Manga m5 = new Manga {NomeManga = "Overlord",Autor = a4,Genero = g3};
                Manga m6 = new Manga {NomeManga = "The Beginning After The End",Autor = a5,Genero = g4};
                Manga m7 = new Manga {NomeManga = "The Hero Returns",Autor = a6,Genero = g1};
                Manga m8 = new Manga {NomeManga = "One Piece",Autor = a7,Genero = g5};
                Manga m9 = new Manga {NomeManga = "Black Clover",Autor = a8,Genero = g1};

                context.Mangas.AddRange(m1,m2,m3,m4,m5,m6,m7,m8,m9);
                context.SaveChanges();
            }
        }
    }
}