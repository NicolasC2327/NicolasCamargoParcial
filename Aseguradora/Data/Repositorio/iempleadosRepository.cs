using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;

namespace Data.Repositorio
{
    public interface iempleadosRepository
    {
        Task<IEnumerable<empleados>> getEmpleados();
        Task<empleados> getEmpleadosbyID(int ID);
        Task<bool> insertEmpleado(empleados empleados);
        Task<bool> updateEmpleado(empleados empleados);
        Task<bool> deleteEmpleado(int ID);
    }
}
