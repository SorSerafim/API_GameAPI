using GameApi.Domain.Models;
using System.Collections.Generic;

namespace GameApi.Domain.Interfaces
{
    public interface IOgroRepository : IRepository<Ogro>
    {
        Ogro RetornaOgroPorId(int id);
        List<Ogro> RetornaTodosOsOgros();
    }
}
