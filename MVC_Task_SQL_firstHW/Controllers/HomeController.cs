using Microsoft.AspNetCore.Mvc;
using MVC_Task_SQL_firstHW.DAL;
using MVC_Task_SQL_firstHW.Models;

namespace MVC_Task_SQL_firstHW.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Brands.ToList());
        }
    }
}
