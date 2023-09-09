using Modelo;
using MySql.Data.MySqlClient;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
    public class ventasRepository : iventasRepository
    {
        public readonly mysqlConfig _connection;
        public ventasRepository(mysqlConfig connection)
        {
            _connection = connection;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connection._connectionString);
        }
        public Task<bool> deleteVenta(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ventas>> getVentas()
        {
            var db = dbConnection();
            var consulta = @"select * from ventas";
            return db.QueryAsync<ventas>(consulta);
        }

        public Task<ventas> getVentasByID(int ID)
        {
            var db = dbConnection();
            var consulta = @"select * from ventas where ID=@ID ";
            return db.QueryFirstOrDefaultAsync<ventas>(consulta, new { Id = ID });
        }

        public Task<bool> insertVentas(ventas ventas)
        {
            throw new NotImplementedException();
        }

        public Task<bool> updateVentas(ventas ventas)
        {
            throw new NotImplementedException();
        }
    }
}
