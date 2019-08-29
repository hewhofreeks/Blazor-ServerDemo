using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemo_Server.Data
{
    public class CraftJackContext : DbContext
    {
        public CraftJackContext(DbContextOptions<CraftJackContext> options)
            : base(options)
        { }

        public DbSet<Contractor> Contractors { get; set; }
    }
}
