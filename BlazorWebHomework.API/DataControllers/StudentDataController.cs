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

        public StudentViewModel? GetStudentById(int studentId)
        {
            using var connection = GetConnection();
            connection.Open();
            var row = connection.QueryFirstOrDefault<StudentViewModel>(
                DatabaseConstants.GetStudentById,
                new
                {
                    studentId
                },
                commandType: CommandType.StoredProcedure);
            return row;

        }

        public int? CreateStudent(Student student)
        {
            using var connection = GetConnection();
            connection.Open();
            var row = connection.QueryFirstOrDefault<int>(
                DatabaseConstants.CreateStudent,
                new
                {
                    student.StudentFirstName,
                    student.StudentLastName,
                    student.StudentGroupId,
                    student.StudentAvgScore,
                    student.StudentRegistrationDate
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }

        public int DeleteStudent(int studentId)
        {
            using var connection = GetConnection();
            connection.Open();
            var row = connection.Execute(
                DatabaseConstants.DeleteStudent,
                new
                {
                    studentId,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }
    }
}
