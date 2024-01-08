using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MINT_WebAPI.Constants;
using BlazorWebHomework.Models;
using System.Data;

namespace MINT_WebAPI.DataControllers
{
    public class CategoriesDataController
    {
        private readonly string _connectionString;

        private SqlConnection GetConnection() => new(_connectionString);

        public CategoriesDataController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            using var connection = GetConnection();
            connection.Open();

            var rows = connection.Query<Category>(
                DatabaseConstants.GetAllCategories,
                commandType: CommandType.StoredProcedure);
            return rows;
        }

        public Category? GetCategoryById(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            var row = connection.QueryFirstOrDefault<Category>(
                DatabaseConstants.GetCategoryById,
                new
                {
                    CategoryId = id,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }

        public Category? GetCategoryByName(string name)
        {
            using var connection = GetConnection();
            connection.Open();

            var row = connection.QueryFirstOrDefault<Category>(
                DatabaseConstants.GetCategoryByName,
                new
                {
                    CategoryName = name,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }

        public int CreateCategory(Category category)
        {
            using var connection = GetConnection();
            connection.Open();

            var row = connection.Execute(
                DatabaseConstants.CreateCategory,
                new
                {
                    category.CategoryName,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }

        public int UpdateCategory(Category category)
        {
            using var connection = GetConnection();
            connection.Open();

            var row = connection.Execute(
                DatabaseConstants.UpdateCategory,
                new
                {
                    category.CategoryId,
                    category.CategoryName,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }

        public int DeleteCategoryById(int id)
        {
            using var connection = GetConnection();
            connection.Open();

            var row = connection.Execute(
                DatabaseConstants.DeleteCategoryById,
                new
                {
                    CategoryId = id,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }
    }
}
