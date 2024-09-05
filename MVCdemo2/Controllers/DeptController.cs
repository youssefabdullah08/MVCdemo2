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
        private readonly UOW uOW;

        public DeptController(IDeprtmentServes dept, UOW uOW)
        {
            this.dept = dept;
            this.uOW = uOW;
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
    }
}
