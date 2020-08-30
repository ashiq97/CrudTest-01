using CRUD_With_CoreMvc_test_01.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUD_With_CoreMvc_test_01.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ApplicationContext _context;
        public SchoolController(ApplicationContext context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _context.Schools.ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(School school)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.Schools.Add(school);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var getElement = _context.Schools.Find(id);

            if (getElement == null)
            {
                return NotFound();
            }
            return View(getElement);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(School school)
        {
            if (ModelState.IsValid)
            {
                _context.Schools.Update(school);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(school);
        }

        public IActionResult Delete(int id)
        {
            var findSchool = _context.Schools.Find(id);
            if(findSchool != null)
            {
                return View(findSchool);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(School school)
        {
            var getSchool = _context.Schools.FirstOrDefault(x => x.SchoolId == school.SchoolId);
            if (getSchool.SchoolId != 0)
            {
                _context.Schools.Remove(getSchool);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
