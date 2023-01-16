using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Proiect2.Models;

namespace Proiect2.Data
{
    public class Proiect2Context : DbContext
    {
        public Proiect2Context (DbContextOptions<Proiect2Context> options)
            : base(options)
        {
        }

        public DbSet<Proiect2.Models.Manichiura> Manichiura { get; set; } = default!;

        public DbSet<Proiect2.Models.Client> Client { get; set; }

        public DbSet<Proiect2.Models.Salariat> Salariat { get; set; }

        public DbSet<Proiect2.Models.Operatiune> Operatiune { get; set; }
    }
}
