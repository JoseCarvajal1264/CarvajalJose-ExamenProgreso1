using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarvajalJose_ExamenProgreso1.Models;

namespace CarvajalJose_ExamenProgreso1.Data
{
    public class CarvajalJose_ExamenProgreso1Context : DbContext
    {
        public CarvajalJose_ExamenProgreso1Context (DbContextOptions<CarvajalJose_ExamenProgreso1Context> options)
            : base(options)
        {
        }

        public DbSet<CarvajalJose_ExamenProgreso1.Models.Carvajal> Carvajal { get; set; } = default!;
        public DbSet<CarvajalJose_ExamenProgreso1.Models.Celular> Celular { get; set; } = default!;
    }
}
