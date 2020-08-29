using CRUD_With_CoreMvc_test_01.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUD_With_CoreMvc_test_01.Controllers
{
    public class SchoolController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(School school)
        {

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View();
        }

        public IActionResult Edit(School school)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            return RedirectToAction("Index");
        }
    }
}
