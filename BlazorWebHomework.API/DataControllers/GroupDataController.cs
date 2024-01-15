using BlazorWebHomework.Models;
using Group = BlazorWebHomework.Models.Group;
using Dapper;
using Microsoft.Data.SqlClient;
using MINT_WebAPI.Constants;
using System.Data;
using System.Text.RegularExpressions;

namespace BlazorWebHomework.API.DataControllers
{
    public class GroupDataController
    {
        private readonly string _connectionString;

        private SqlConnection GetConnection() => new(_connectionString);

        public GroupDataController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        public IEnumerable<Group> GetAllGroups()
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Query<Group>(
                DatabaseConstants.GetAllGroups,
                commandType: CommandType.StoredProcedure);
            return rows;
        }
    }
}
