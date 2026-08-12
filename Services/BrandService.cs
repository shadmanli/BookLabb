using BookWork.Data;
using BookWork.Services.Interfaces;
using BookWork.ViewModels.Brand;
using Microsoft.EntityFrameworkCore;

namespace BookWork.Services
{
    public class BrandService : IBrandService
    {
        private readonly AppDbContext _context;
        public BrandService(AppDbContext context)
        {
             _context = context;
        }
        public async Task<IEnumerable<BrandUIVM>> GetAllUIAsync()
        {
            IEnumerable<BrandUIVM> brands = await _context.Brands.Select(m => new BrandUIVM
            {
                Image = m.Image
            }).ToListAsync();
            return brands;
        }
    }
}
