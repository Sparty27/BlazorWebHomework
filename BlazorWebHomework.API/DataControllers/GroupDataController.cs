using BlazorWebHomework.Models;
using Group = BlazorWebHomework.Models.Group;
using Dapper;
using Microsoft.Data.SqlClient;
using MINT_WebAPI.Constants;
using System.Data;
using System.Text.RegularExpressions;
using System.Threading.Tasks.Dataflow;

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

        public IEnumerable<Group> GetGroups(int skip, int take)
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Query<Group>(
                DatabaseConstants.GetGroups,
                new
                {
                    skip,
                    take,
                },
                commandType: CommandType.StoredProcedure);
            return rows;
        }

        public int? GetCount()
        {
            using var connection = GetConnection();
            connection.Open();

            var row = connection.QueryFirstOrDefault<int>(
                DatabaseConstants.GetCount,
                commandType: CommandType.StoredProcedure);
            return row;
        }

        public int DeleteGroup(int groupId)
        {
            using var connection = GetConnection();
            connection.Open();
            var row = connection.Execute(
                DatabaseConstants.DeleteGroup,
                new
                {
                    groupId,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }
    }
}
