using AutoMapper;
using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
using GameApi.Shared.Dtos.Create;
using GameApi.Shared.Dtos.Read;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace GameApi.Data.Repositories
{
    public class EquipamentoRepository : IEquipamentoRepository
    {
        private GameApiContext _context;

        public EquipamentoRepository(GameApiContext context)
        {
            _context = context;
        }

        public void AdicionaEquipamento(Equipamento equipamento)
        {
            _context.Equipamentos.Add(equipamento);
            _context.SaveChanges();
        }

        public List<Equipamento> RetornaTodosOsEquipamentos()
        {
            return _context.Equipamentos.Include(x => x.PlayerEquipamentos).ToList();
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

        public Equipamento RetornaEquipamentoPorId(int id)
        {
            Equipamento equipamento = _context.Equipamentos.FirstOrDefault(x => x.Id == id);
            return equipamento;
        }
    }
}