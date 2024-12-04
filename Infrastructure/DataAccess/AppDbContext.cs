using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<DepositoEntity> Deposito { get; set; }
        public DbSet<UbicacionEntity> Ubicacion { get; set; }
        public DbSet<PalletEntity> Pallet { get; set; }
        public DbSet<StockMovimientoEntity> StockMovimiento { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }

}
