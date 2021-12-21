using AutoMapper;
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
    public class PlayerEquipamentoRepository : IPlayerEquipamentoRepository
    {
        private GameApiContext _context;

        private IMapper _mapper;

        public PlayerEquipamentoRepository(GameApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AdicionaPlayerEquipamento(PlayerEquipamentos playerEquipamentos)
        {
            _context.PlayerEquipamentos.Add(playerEquipamentos);
            _context.SaveChanges();
        }

        public void DeletaPlayerEquipamento(int id)
        {
            PlayerEquipamentos playerEquipamentos = _context.PlayerEquipamentos.FirstOrDefault(x => x.Id==id);
            if(playerEquipamentos != null)
            {
                _context.Remove(playerEquipamentos);
                _context.SaveChanges();
            }
        }

        public List<PlayerEquipamentos> RetornaTodosOsPlayerEquipamentos()
        {
            List<PlayerEquipamentos> playerEquipamentos = _context.PlayerEquipamentos.ToList();
            return playerEquipamentos;
        }
    }
}