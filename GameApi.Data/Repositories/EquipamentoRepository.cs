using GameApi.Data.Context;
using GameApi.Domain.Interfaces;
using GameApi.Domain.Models;
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

        public void AtualizaEquipamento(Equipamento novoEquipamento)
        {
            _context.Update(novoEquipamento);
            _context.SaveChanges();
        }

        public void DeletaEquipamento(Equipamento equipamento)
        {
            _context.Remove(equipamento);
            _context.SaveChanges();
        }

        public Equipamento RetornaEquipamentoPorId(int id)
        {
            return _context.Equipamentos.FirstOrDefault(x => x.Id == id);
        }
    }
}