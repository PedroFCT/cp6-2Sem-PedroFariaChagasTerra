using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cp6_2Sem_PedroFariaChagasTerra.Models;

namespace cp6_2Sem_PedroFariaChagasTerra.Data
{
    public class cp6_2Sem_PedroFariaChagasTerraContext : DbContext
    {
        public cp6_2Sem_PedroFariaChagasTerraContext (DbContextOptions<cp6_2Sem_PedroFariaChagasTerraContext> options)
            : base(options)
        {
        }

        public DbSet<cp6_2Sem_PedroFariaChagasTerra.Models.Modelo> Modelo { get; set; } = default!;

        public DbSet<cp6_2Sem_PedroFariaChagasTerra.Models.Carro>? Carro { get; set; }

        public DbSet<cp6_2Sem_PedroFariaChagasTerra.Models.Acessorio>? Acessorio { get; set; }
    }
}
