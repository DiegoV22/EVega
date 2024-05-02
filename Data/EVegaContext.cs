using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EVega.Models;

namespace EVega.Data
{
    public class EVegaContext : DbContext
    {
        public EVegaContext (DbContextOptions<EVegaContext> options)
            : base(options)
        {
        }

        public DbSet<EVega.Models.Estudiante> Estudiante { get; set; } = default!;

        public DbSet<EVega.Models.Carrera>? Carrera { get; set; }
    }
}
