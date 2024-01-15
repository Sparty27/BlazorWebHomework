using BlazorWebHomework.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using MINT_WebAPI.Constants;
using System.Data;

namespace BlazorWebHomeworkAPI.DataControllers
{
    public class StudentDataController
    {
        private readonly string _connectionString;

        private SqlConnection GetConnection() => new(_connectionString);

        public StudentDataController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        public IEnumerable<StudentViewModel> GetAllStudents()
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Query<StudentViewModel>(
                DatabaseConstants.GetAllStudents,
                commandType: CommandType.StoredProcedure);
            return rows;
        }
    }
}
