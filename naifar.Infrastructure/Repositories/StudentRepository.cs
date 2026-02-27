using Dapper;
using naifar.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naifar.Infrastructure.Repositories
{
    public class StudentRepository : Repository
    {
        public StudentRepository(string connectionString) : base(connectionString)
        {
            
        }
        public IEnumerable<Student> GetAll()
        {
            using var connection = CreateConnection();
            string sql = @"
            SELECT
                Id,FirstName, LastName
            FROM dbo.naifarTable;
            ";
            return connection.Query<Student>(sql).ToList();
        }

        public void Add(Student student)
        {
            using var connection = CreateConnection();
            string sql = @"INSERT INTO Students (FirstName, LastName) VALUES
                    (@FirstName, @LastName);";
            connection.Execute(sql, new
            {
                FirstName = student.FirstName,
                LastName = student.LastName
            });
        }
    }
}
