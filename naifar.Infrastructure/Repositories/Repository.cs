using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naifar.Infrastructure.Repositories
{
    public class Repository
    {

        private readonly string _connectionString;

        public Repository(string connectionString) {
            _connectionString = connectionString;
        }
        protected IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
