using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NT1A_wAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NT1A_wAuthentication.Data
{
    public class MiDbContext : IdentityDbContext
    {
        public MiDbContext(DbContextOptions<MiDbContext> options) : base(options)
        {

        }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Telefono> Telefonos { get; set; }
    }
}
