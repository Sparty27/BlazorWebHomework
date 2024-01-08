using MINT_WebAPI.DataControllers;
using BlazorWebHomework.Models;

namespace MINT_WebAPI.Managers.CategoryManaging
{
    public class CategoryManager : ICategoryManager
    {
        private readonly CategoriesDataController _categoriesDataController;

        public CategoryManager(IConfiguration configuration)
        {
            _categoriesDataController = new CategoriesDataController(configuration);
        }

        public IEnumerable<Category> GetAllCategories()
            => _categoriesDataController.GetAllCategories();

        public Category? GetCategoryById(int id)
            => _categoriesDataController.GetCategoryById(id);

        public Category? GetCategoryByName(string name)
            => _categoriesDataController.GetCategoryByName(name);

        public int CreateCategory(Category category)
            => _categoriesDataController.CreateCategory(category);

        public int UpdateCategory(Category category)
            => _categoriesDataController.UpdateCategory(category);

        public int DeleteCategoryById(int id)
            => _categoriesDataController.DeleteCategoryById(id);
    }
}
