using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Data.Repositorio
{
    public interface isegurosRepository
    {
        Task<IEnumerable<seguros>> get();
        Task<seguros> getConductoresById(int id);
        Task<bool> insertConductor(seguros seguros);
        Task<bool> updateConductor(seguros seguros);
        Task<bool> deleteConductor(int ID);
    }
}
