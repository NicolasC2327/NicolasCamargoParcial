
using Dapper;
using MySql.Data.MySqlClient;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlX.XDevAPI;

namespace Data.Repositorio
{
    public class clientesRepository : iclientesRepository
    {
        public readonly mysqlConfig _connection;
        public clientesRepository(mysqlConfig connection)
        {
            _connection = connection;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connection._connectionString);
        }
        public Task<bool> deleteCliente(int id)
        {
            throw new NotImplementedException();
        }

        public Task<clientes> getClienteById(int id)
        {
            var db = dbConnection();
            var consulta = @"select * from clientes where ID=@ID ";
            return db.QueryFirstOrDefaultAsync<clientes>(consulta, new { Id = id });
        }
        

        public Task<IEnumerable<clientes>> getClientes()
        {
            var db = dbConnection();
            var consulta = @"select * from clientes";
            return db.QueryAsync<clientes>(consulta);
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
