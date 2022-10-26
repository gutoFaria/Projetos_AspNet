using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_tickey.Data.Base;
using e_tickey.Models;

namespace e_tickey.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(AppDbContext context) : base(context)
        {
        }
        
    }
}