using GameApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace GameApi.Data.Context
{
    public class GameApiContext : DbContext
    {
        public DbSet<Ogro> Ogros { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Equipamento> Equipamentos { get; set; }
        public DbSet<PlayerEquipamentos> PlayerEquipamentos { get; set; }
        public GameApiContext(DbContextOptions<GameApiContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerEquipamentos>()
                .HasKey(playerEquipamento => playerEquipamento.Id);

            modelBuilder.Entity<PlayerEquipamentos>()
                .HasOne(playerEquipamentos => playerEquipamentos.Player)
                .WithMany(player => player.PlayerEquipamentos)
                .HasForeignKey(playerEquipamentos => playerEquipamentos.PlayerId);

            modelBuilder.Entity<PlayerEquipamentos>()
                .HasOne(playerEquipamentos => playerEquipamentos.Equipamento)
                .WithMany(equipamento => equipamento.PlayerEquipamentos)
                .HasForeignKey(playerEquipamentos => playerEquipamentos.EquipamentoId);
        }

        //internal List<object> ToList()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
