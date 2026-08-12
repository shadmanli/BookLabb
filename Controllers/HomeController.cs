using BookWork.Data;
using BookWork.Models;
using BookWork.Services.Interfaces;
using BookWork.ViewModels.Book;
using BookWork.ViewModels.Brand;
using BookWork.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BookWork.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBrandService _brandService;
        private readonly IBookService _bookService;
        public HomeController(IBrandService brandService, IBookService bookService)
        {
            _brandService = brandService;
            _bookService = bookService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<BrandUIVM> brands = await _brandService.GetAllUIAsync();
            IEnumerable<BookUIVM> books = await _bookService.GetAllUIAsync();

            HomeVM homeVM = new HomeVM
            {
                Brands = brands,
                Books = books
            };

            return View(homeVM);
        }
    }
}
