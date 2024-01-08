namespace MINT_WebAPI.Constants
{
    public static class DatabaseConstants
    {
        #region Brand
        public const string GetAllBrands = "sp_Brands_GetAllBrands";
        public const string GetBrandById = "sp_Brands_GetBrandById";
        public const string GetBrandByName = "sp_Brands_GetBrandByName";
        public const string CreateBrand = "sp_Brands_CreateBrand";
        public const string UpdateBrand = "sp_Brands_UpdateBrand";
        public const string DeleteBrandById = "sp_Brands_DeleteBrandById";
        #endregion

        #region Category
        public const string GetAllCategories = "sp_Categories_GetAllCategories";
        public const string GetCategoryById = "sp_Categories_GetCategoryById";
        public const string GetCategoryByName = "sp_Categories_GetCategoryByName";
        public const string CreateCategory = "sp_Categories_CreateCategory";
        public const string UpdateCategory = "sp_Categories_UpdateCategory";
        public const string DeleteCategoryById = "sp_Categories_DeleteCategoryById";
        #endregion

        #region Customer
        public const string GetAllCustomers = "sp_Customers_GetAllCustomers";
        public const string GetCustomerById = "sp_Customers_GetCustomerById";
        public const string GetCustomerByName = "sp_Customers_GetCustomerByName";
        public const string CreateCustomer = "sp_Customers_CreateCustomer";
        public const string UpdateCustomer = "sp_Customers_UpdateCustomer";
        public const string DeleteCustomerById = "sp_Customers_DeleteCustomerById";
        #endregion

        #region Store
        public const string GetAllStores = "sp_Stores_GetAllStores";
        public const string GetStoreById = "sp_Stores_GetStoreById";
        public const string GetStoreByName = "sp_Stores_GetStoreByName";
        public const string CreateStore = "sp_Stores_CreateStore";
        public const string UpdateStore = "sp_Stores_UpdateStore";
        public const string DeleteStoreById = "sp_Stores_DeleteStoreById";
        #endregion

        #region Product
        public const string GetAllProducts = "sp_Products_GetAllProducts";
        public const string GetProductById = "sp_Products_GetProductById";
        public const string GetProductByName = "sp_Products_GetProductByName";
        public const string CreateProduct = "sp_Products_CreateProduct";
        public const string UpdateProduct = "sp_Products_UpdateProduct";
        public const string DeleteProductById = "sp_Products_DeleteProductById";
        #endregion

        #region Faculties
        public const string GetAllFaculties = "sp_Faculties_GetAllFaculties";
        public const string GetFaculties = "sp_Faculties_GetFaculties";
        #endregion

        #region Departments
        public const string GetAllDepartments = "sp_Departments_GetAllDepartments";
        #endregion
    }
}
