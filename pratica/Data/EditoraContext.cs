using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using pratica.Models;

namespace pratica.Data
{
    public class EditoraContext : DbContext
    {
        public EditoraContext(DbContextOptions<EditoraContext> options) : base(options)
        {}

        public DbSet<Editora>? Editoras { get; set;}
    }
}