using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Data.Repositorio
{
    public interface iventasRepository 
    {
        Task<IEnumerable<ventas>> getVentas();
        Task<ventas> getVentasByID(int ID);
        Task<bool> insertVentas(ventas ventas);
        Task<bool> updateVentas(ventas ventas);
        Task<bool> deleteVenta(int ID);
    }
}
