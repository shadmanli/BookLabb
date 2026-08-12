using BookWork.ViewModels.Brand;

namespace BookWork.Services.Interfaces
{
    public interface IBrandService
    {
        Task<IEnumerable<BrandUIVM>> GetAllUIAsync();
    }
}
