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
        public async Task<bool> deleteVenta(int ID)
        {
            var db = dbConnection();
            var sql = @"delete from ventas where ID=@ID";
            var result = await db.ExecuteAsync(sql, new { ID });
            return result > 0;
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

        public async Task<bool> insertVentas(ventas ventas)
        {
            var db = dbConnection();
            var sql = @"insert into ventas
                    (Clientes_ID, Empleados_ID, Seguros_ID)
                    values(@Clientes_ID, @Empleados_ID, @Seguros_ID)";
            var result = await db.ExecuteAsync(sql, new { ventas.clientes_ID, ventas.Empleados_ID, ventas.Seguros_ID });

            return result > 0;
        }

        public Task<bool> updateVentas(ventas ventas)
        {
            throw new NotImplementedException();
        }
    }
}
