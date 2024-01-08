using BlazorWebHomework.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using MINT_WebAPI.Constants;
using System.Data;

namespace BlazorWebHomeworkAPI.DataControllers
{
    public class FacultyDataController
    {
        private readonly string _connectionString;

        private SqlConnection GetConnection() => new(_connectionString);

        public FacultyDataController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        public IEnumerable<FacultyWithDepartmentsModel> GetAllFaculties()
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Query<FacultyWithDepartmentsModel>(
                DatabaseConstants.GetAllFaculties,
                commandType: CommandType.StoredProcedure);
            return rows;
        }

        public IEnumerable<Faculty> GetFaculties()
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Query<Faculty>(
                DatabaseConstants.GetFaculties,
                commandType: CommandType.StoredProcedure);
            return rows;
        }
    }
}
