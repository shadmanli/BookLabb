using BookWork.Data;
using BookWork.Models;
using BookWork.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BookWork.Controllers
{
    public class HomeController : Controller
    {
        private  readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Brand> brands = await _context.Brands.ToListAsync();
          
          

            return View(brands);
        }
    }
}
