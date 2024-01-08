using BlazorWebHomework.Models;

namespace MINT_WebAPI.Managers.StoreManaging
{
    public interface IStoreManager
    {
        IEnumerable<Store> GetAllStores();
        Store? GetStoreById(int id);

        Store? GetStoreByName(string name);
        int CreateStore(Store store);

        int UpdateStore(Store store);

        int DeleteStoreById(int id);
    }
}
