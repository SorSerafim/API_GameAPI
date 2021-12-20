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

        public void AdicionaPlayerEquipamento(CreatePlayerEquipamentoDto playerEquipamentoDto)
        {
            PlayerEquipamentos playerEquipamentos = _mapper.Map<PlayerEquipamentos>(playerEquipamentoDto);
            _context.PlayerEquipamentos.Add(playerEquipamentos);
            _context.SaveChanges();
        }

        public List<PlayersDoEquipamento> RetornaTodosOsPlayersEquipamentos()
        {
            List<PlayerEquipamentos> playerEquipamentos = _context.PlayerEquipamentos.Include(x => x.Player).Include(x => x.Equipamento).ToList();
            List<PlayersDoEquipamento> playerEquipamentoDtos = _mapper.Map<List<PlayersDoEquipamento>>(playerEquipamentos);
            return playerEquipamentoDtos;
        }
    }
}
