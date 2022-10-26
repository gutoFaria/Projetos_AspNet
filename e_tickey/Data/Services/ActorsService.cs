using e_tickey.Models;
using Microsoft.EntityFrameworkCore;
using e_tickey.Data.Base;

namespace e_tickey.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) {}
        
    }
}