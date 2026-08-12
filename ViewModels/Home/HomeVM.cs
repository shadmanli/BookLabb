using BookWork.Models;
using BookWork.ViewModels.Book;
using BookWork.ViewModels.Brand;

namespace BookWork.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<BrandUIVM> Brands { get; set; }
        
        public IEnumerable<BookUIVM> Books { get; set; }


    }
}
