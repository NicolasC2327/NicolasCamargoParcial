
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
    public class clientesRepository : iclientesRepository
    {
        public Task<bool> deleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<clientes> getClienteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<clientes>> getClientes()
        {
            throw new NotImplementedException();
        }

        public Task<bool> insertCliente(clientes cliente)
        {
            throw new NotImplementedException();
        }

        public Task<bool> updateCliente(clientes cliente)
        {
            throw new NotImplementedException();
        }
    }
}
