using CaterServMongoDb.Dtos.CategoryDtos;

namespace CaterServMongoDb.Services.Abstract
{
    public interface ICategoryService  //metotları async yapmamızın sebebi mongodb ile çalışırken tüm metotlarımız async olcağı için tüm metotlarımızı async yaptık
    {
        Task<List<ResultCategoryDto>> GetAllCategories();
        Task<ResultCategoryDto> GetCategoryById(string id);
        Task UpdateCategory(UpdateCategoryDto categoryDto);
        Task CreateCategory(CreateCategoryDto categoryDto);
        Task DeleteCategory(string id);
    }
}
