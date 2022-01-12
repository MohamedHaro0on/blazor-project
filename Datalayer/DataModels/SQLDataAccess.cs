using System;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Data;

namespace Datalayer.DataModels
{
    public class SQLDataAccess:ISQLDataAccess
    {
        public string connectionStringName { get; set; } = "DefaultConnection";
        private IConfiguration _config;
        public SQLDataAccess(IConfiguration config)
        {
            _config = config;
        }

        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = "Data Source=.;Initial Catalog=Employee;Integrated Security=True";

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);
                return data.ToList();
            }

        }
        public async Task SaveData<T>(string sql, T parameters)
        {
            string connectionString = "Data Source=.;Initial Catalog=FutureBlazor;Integrated Security=True";
            using (System.Data.IDbConnection connection = new SqlConnection(connectionString))
            {
                await connection.ExecuteAsync(sql, parameters);
            }
        }
    }
}
