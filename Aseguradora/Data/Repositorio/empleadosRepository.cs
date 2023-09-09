using Dapper;
using MySql.Data.MySqlClient;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositorio
{
    public class empleadosRepository : iempleadosRepository
    {
        public readonly mysqlConfig _connection;
        public empleadosRepository(mysqlConfig connection)
        {
            _connection = connection;
        }
        protected MySqlConnection dbConnection()
        {
            return new MySqlConnection(_connection._connectionString);
        }
        public async Task<bool> deleteEmpleado(int ID)
        {
            var db = dbConnection();
            var sql = @"delete from empleados where ID=@ID";
            var result = await db.ExecuteAsync(sql, new { ID });
            return result > 0;
        }

        public Task<IEnumerable<empleados>> getEmpleados()
        {
            var db = dbConnection();
            var consulta = @"select * from empleados";
            return db.QueryAsync<empleados>(consulta);
        }

        public Task<empleados> getEmpleadosbyID(int ID)
        {
            var db = dbConnection();
            var consulta = @"select * from empleados where ID=@ID ";
            return db.QueryFirstOrDefaultAsync<empleados>(consulta, new { Id = ID });
        }

        public async Task<bool> insertEmpleado(empleados empleados)
        {
            var db = dbConnection();
            var sql = @"insert into empleados
                    (Nombre, Edad, NumDoc)
                    values(@Nombre, @Edad, @NumDoc)";
            var result = await db.ExecuteAsync(sql, new { empleados.Nombre, empleados.Edad, empleados.NumDoc });

            return result > 0;
        }

        public Task<bool> updateEmpleado(empleados conductor)
        {
            throw new NotImplementedException();
        }
    }
}
