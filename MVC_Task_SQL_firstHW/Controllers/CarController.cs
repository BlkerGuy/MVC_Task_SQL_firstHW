using Microsoft.AspNetCore.Mvc;
using MVC_Task_SQL_firstHW.DAL;
using MVC_Task_SQL_firstHW.Models;

namespace MVC_Task_SQL_firstHW.Controllers
{
    public class CarController : Controller
    {
        private readonly AppDbContext _context;

        public CarController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {
            if (id == null) return BadRequest();
            if (!_context.Cars.Any(c => c.ModelId == id)) return NotFound();

            return View(_context.Cars.Where(c=>c.ModelId==id).ToList());
        }

        public IActionResult Detail(int? id)   
        {
            if (id == null) return BadRequest();
            if (!_context.Cars.Any(c => c.Id == id)) return NotFound();

            return View(_context.Cars.Where(c => c.Id == id).ToList());
        }

    }
}
