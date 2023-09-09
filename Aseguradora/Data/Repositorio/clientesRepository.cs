
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
        public async Task<bool> deleteCliente(int id)
        {
            var db = dbConnection();
            var sql = @"delete from clientes where ID=@ID";
            var result = await db.ExecuteAsync(sql, new { id });
            return result > 0;
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

        public async Task<bool> insertCliente(clientes cliente)
        {
            var db = dbConnection();
            var sql = @"insert into clientes
                    (Nombre, Edad, NumDoc) 
                    values(@Nombre, @Edad, @NumDoc)";
            var result = await db.ExecuteAsync(sql, new { cliente.Nombre, cliente.Edad, cliente.NumDoc });

            return result > 0;
        }

        public Task<bool> updateCliente(clientes cliente)
        {
            throw new NotImplementedException();
        }
    }
}
