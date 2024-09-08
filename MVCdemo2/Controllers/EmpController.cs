using Compny.Data.Entites;
using Compny.Repos.InterFaces;
using Microsoft.AspNetCore.Mvc;

namespace MVCdemo2.Controllers
{
    public class EmpController : Controller
    {
        private readonly IEmp emp;

        public EmpController(IEmp emp)
        {
            this.emp = emp;
        }
        public IActionResult Index()
        {
            var x = emp.GetAll();

            return View(x);
        }
        public IActionResult Details(int id)
        {
            var x = emp.GetById(id);
            return View(x);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Emp emp1)
        {
            emp.Add(emp1);
            return RedirectToAction("Index");
        }

        public void Delete(int id)
        {
            emp.Delete(emp.GetById(id));
        }
        public IActionResult Edit(Emp emp1)
        {
            emp.Update(emp1);
            return RedirectToAction("Index");
        }
    }
}
