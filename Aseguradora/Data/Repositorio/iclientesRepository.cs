using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Data.Repositorio
{
    public interface iclientesRepository
    {
        Task<IEnumerable<clientes>> getClientes();
        Task<clientes> getClienteById(int ID);
        Task<bool> insertCliente(clientes cliente);
        Task<bool> updateCliente(clientes cliente);
        Task<bool> deleteCliente(int ID);
    }
}
