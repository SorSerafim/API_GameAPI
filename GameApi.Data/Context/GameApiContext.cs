using GameApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Data.Context
{
    public class GameApiContext : DbContext
    {
        public DbSet<Ogro> Ogros { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Equipamento> Equipamentos { get; set; }

        public GameApiContext(DbContextOptions<GameApiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipamento>()
                .HasOne(equipamento => equipamento.Player)
                .WithMany(player => player.Equipamentos)
                .HasForeignKey(equipamento => equipamento.PlayerId);
        }
    }
}
