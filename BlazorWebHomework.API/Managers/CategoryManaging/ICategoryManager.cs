using BlazorWebHomework.Models;

namespace MINT_WebAPI.Managers.CategoryManaging
{
    public interface ICategoryManager
    {
        IEnumerable<Category> GetAllCategories();
        Category? GetCategoryById(int id);

        Category? GetCategoryByName(string name);
        int CreateCategory(Category category);

        int UpdateCategory(Category category);

        int DeleteCategoryById(int id);
    }
}
