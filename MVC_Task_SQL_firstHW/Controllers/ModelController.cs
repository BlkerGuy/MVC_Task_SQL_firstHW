using Microsoft.AspNetCore.Mvc;
using MVC_Task_SQL_firstHW.DAL;
using MVC_Task_SQL_firstHW.Models;

namespace MVC_Task_SQL_firstHW.Controllers
{
    public class ModelController : Controller
    {
        private readonly AppDbContext _context;

        public ModelController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (id == null) BadRequest();

            if (!_context.Models.Any(m => m.BrandId == id)) return NotFound();

            return View(_context.Models.Where(m=>m.BrandId==id).ToList());
        }
    }
}
