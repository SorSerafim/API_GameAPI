﻿using AutoMapper;
using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Data.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        public GameApiContext _context;

        public IMapper _mapper;

        public PlayerRepository(GameApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
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