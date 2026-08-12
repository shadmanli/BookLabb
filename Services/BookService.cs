using BookWork.Data;
using BookWork.Services.Interfaces;
using BookWork.ViewModels.Book;
using Microsoft.EntityFrameworkCore;

namespace BookWork.Services
{
    public class BookService : IBookService
    {
        private readonly AppDbContext _context;
        public BookService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<BookUIVM>> GetAllUIAsync()
        {
            IEnumerable<BookUIVM> books = await _context.Books.Include(b => b.BookImages).Select(m => new BookUIVM
            {
                Name = m.Name,
                Id = m.Id,
                Description = m.Description,
                Price = m.Price,
                MainImage = m.BookImages.FirstOrDefault(b => b.IsMain).Name,
                IsFeatured = m.IsFeatured
            }).ToListAsync();
            return books;
        }
    }
}
