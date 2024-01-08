using MINT_WebAPI.DataControllers;
using BlazorWebHomework.Models;

namespace MINT_WebAPI.Managers.StoreManaging
{
    public class StoreManager : IStoreManager
    {
        private readonly StoresDataController _storesDataController;

        public StoreManager(IConfiguration configuration)
        {
            _storesDataController = new StoresDataController(configuration);
        }

        public IEnumerable<Store> GetAllStores()
            => _storesDataController.GetAllStores();

        public Store? GetStoreById(int id)
            => _storesDataController.GetStoreById(id);

        public Store? GetStoreByName(string name)
            => _storesDataController.GetStoreByName(name);

        public int CreateStore(Store store)
            => _storesDataController.CreateStore(store);

        public int UpdateStore(Store store)
            => _storesDataController.UpdateStore(store);

        public int DeleteStoreById(int id)
            => _storesDataController.DeleteStoreById(id);
    }
}
