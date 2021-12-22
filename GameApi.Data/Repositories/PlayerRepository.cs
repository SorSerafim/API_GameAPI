﻿using AutoMapper;
using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public GameApiContext _context;

        public PlayerRepository(GameApiContext context)
        {
            _context = context;
        }

        public void AdicionaPlayer(Player player)
        {
            _context.Players.Add(player);
            _context.SaveChanges();
        }

        public List<Player> RetornaTodosOsPlayers()
        {
            return _context.Players.Include(x => x.PlayerEquipamentos).ThenInclude(x => x.Equipamento).ToList();
        }

        public void AtualizaPlayer(int id, Player novoPlayer)
        {
            Player player = _context.Players.FirstOrDefault(x => x.Id == id);
            if(player != null)
            {
                player.Nome = novoPlayer.Nome;
                player.Vida = novoPlayer.Vida;
                player.Level = novoPlayer.Level;
                _context.SaveChanges();
            }
        }

        public void DeletaPlayer(int id)
        {
            Player player = _context.Players.FirstOrDefault(x => x.Id == id);
            if(player != null)
            {
                _context.Remove(player);
                _context.SaveChanges();
            }
        }

        public Player RetornaPlayerPorId(int id)
        {
            Player player = _context.Players.FirstOrDefault(x => x.Id==id);
            return player;
        }
    }
}