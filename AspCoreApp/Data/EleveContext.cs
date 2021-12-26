using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AspCoreApp.Models;

namespace AspCoreApp.Data
{
    public class EleveContext : DbContext
    {
        public EleveContext (DbContextOptions<EleveContext> options)
            : base(options)
        {
        }

        public DbSet<AspCoreApp.Models.Eleve> Eleve { get; set; }
    }
}
