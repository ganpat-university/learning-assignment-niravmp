using Microsoft.AspNetCore.Mvc;

using Demo23_WebApp.Data;
using System.Linq;

namespace Demo23_WebApp.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DepartmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            // --- using LINQ
            //var query = from dept in _context.Departments
            //            select dept;
            //return View(query);

            //--- using LAMBDA
            var depts = _context.Departments.ToList();
            return View(depts);
        }
    }
}
