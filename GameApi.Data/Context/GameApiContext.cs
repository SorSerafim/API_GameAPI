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
        public GameApiContext(DbContextOptions<GameApiContext> options) : base(options)
        {

        }

        public DbSet<Ogro> Ogros { get; set; }

        public DbSet<Player> Players { get; set; }
    }
}
