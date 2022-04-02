using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LoginAndRegister.Data
{
    public class LogingDbContext : IdentityDbContext
    {
        public LogingDbContext(DbContextOptions<LogingDbContext> options) : base(options)
        {}
    
    }
}