using AutoMapper;
using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApi.Data.Repositories
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        private GameApiContext _context;

        private IMapper _mapper;

        public EquipamentoRepository(GameApiContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AdicionaEquipamento(CreateEquipamentoDto equipamentoDto)
        {
            Equipamento equipamento = _mapper.Map<Equipamento>(equipamentoDto);
            _context.Equipamentos.Add(equipamento);
            _context.SaveChanges();
        }

        public List<ReadEquipamentoDto> RetornaTodosOsEquipamentos()
        {
            List<Equipamento> equipamentos = _context.Equipamentos.ToList();
            List<ReadEquipamentoDto> equipamentosDtos = _mapper.Map<List<ReadEquipamentoDto>>(equipamentos);
            return equipamentosDtos;
        }

        public void AtualizaEquipamento(int id, Equipamento novoEquipamento)
        {
            Equipamento equipamento = _context.Equipamentos.FirstOrDefault(x => x.Id == id);
            if(equipamento != null)
            {
                equipamento.Nome = novoEquipamento.Nome;
                equipamento.Dano = novoEquipamento.Dano;
                equipamento.Level = novoEquipamento.Level;
                _context.SaveChanges();
            }
        }

        public void DeletaEquipamento(int id)
        {
            Equipamento equipamento = _context.Equipamentos.FirstOrDefault(x => x.Id == id);
            if(equipamento != null)
            {
                _context.Remove(equipamento);
                _context.SaveChanges();
            }
        }
    }
}