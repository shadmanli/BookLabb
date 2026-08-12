using BookWork.ViewModels.Book;

namespace BookWork.Services.Interfaces
{
    public interface IBookService
    {
        Task<IEnumerable<BookUIVM>> GetAllUIAsync();
    }
}
