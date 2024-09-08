using Compny.Data.Contexts;
using Compny.Data.Entites;
using Compny.Repos.InterFaces;
using Compny.Serveses.Interfaces;
using Compny.Serveses.Serveses;
using Microsoft.AspNetCore.Mvc;

namespace MVCdemo2.Controllers
{
    public class DeptController : Controller
    {
        private readonly IDeprtmentServes dept;

        public DeptController(IDeprtmentServes dept)
        {
            this.dept = dept;
        }
        public IActionResult Index()
        {
            var x = dept.GetAll();
            return View(x);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Dept department)
        {
            if (ModelState.IsValid)
            {
                dept.Add(department);
                RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult ViewData(int id)
        {
            var x = dept.GetById(id);

            return View(x);
        }
        public IActionResult Delete(int id)
        {
            dept.Delete(dept.GetById(id));
            return View();
        }
        public IActionResult Update(int id)
        {
            dept.Update(dept.GetById(id));
            return RedirectToAction("Index");
        }
    }
}
