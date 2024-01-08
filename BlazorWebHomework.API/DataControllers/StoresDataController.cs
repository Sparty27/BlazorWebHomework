using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using MINT_WebAPI.Constants;
using BlazorWebHomework.Models;
using System.Data;

namespace MINT_WebAPI.DataControllers
{
    public class StoresDataController
    {
        private readonly string _connectionString;

        private SqlConnection GetConnection() => new(_connectionString);

        public StoresDataController(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection")!;
        }

        public IEnumerable<Store> GetAllStores()
        {
            using var connection = GetConnection();
            connection.Open();
            var rows = connection.Query<Store>(
                DatabaseConstants.GetAllStores,
                commandType: CommandType.StoredProcedure);
            return rows;
        }

        public Store? GetStoreById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var row = connection.QueryFirstOrDefault<Store>(
                DatabaseConstants.GetStoreById,
                new
                {
                    StoreId = id,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }

        public Store? GetStoreByName(string storeName)
        {
            using var connection = GetConnection();
            connection.Open();
            var row = connection.QueryFirstOrDefault<Store>(
                DatabaseConstants.GetStoreByName,
                new
                {
                    StoreName = storeName,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }

        public int CreateStore(Store store)
        {
            using var connection = GetConnection();
            connection.Open();
            var row = connection.Execute(
                DatabaseConstants.CreateStore,
                new
                {
                    store.StoreName,
                    store.Phone,
                    store.Email,
                    store.Street,
                    store.City,
                    store.State,
                    store.ZipCode,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }

        public int UpdateStore(Store store)
        {
            using var connection = GetConnection();
            connection.Open();
            var row = connection.Execute(
                DatabaseConstants.UpdateStore,
                new
                {
                    store.StoreId,
                    store.StoreName,
                    store.Phone,
                    store.Email,
                    store.Street,
                    store.City,
                    store.State,
                    store.ZipCode,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }

        public int DeleteStoreById(int id)
        {
            using var connection = GetConnection();
            connection.Open();
            var row = connection.Execute(
                DatabaseConstants.DeleteStoreById,
                new
                {
                    StoreId = id,
                },
                commandType: CommandType.StoredProcedure);
            return row;
        }
    }
}
