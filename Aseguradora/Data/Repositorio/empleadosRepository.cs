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
        public Task<bool> deleteEmpleado(int ID)
        {
            throw new NotImplementedException();
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

        public Task<bool> insertEmpleado(empleados conductor)
        {
            throw new NotImplementedException();
        }

        public Task<bool> updateEmpleado(empleados conductor)
        {
            throw new NotImplementedException();
        }
    }
}
