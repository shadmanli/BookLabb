using BookWork.Models;

namespace BookWork.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Brand> Brands { get; set; }
        
        public IEnumerable<Book> Books { get; set; }


    }
}
