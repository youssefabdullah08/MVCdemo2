using Compny.Data.Contexts;
using Compny.Repos.InterFaces;
using Microsoft.AspNetCore.Mvc;

namespace MVCdemo2.Controllers
{
    public class DeptController : Controller
    {
        private readonly IDept dept;

        public DeptController(IDept dept)
        {
            this.dept = dept;
        }
        public IActionResult Index()
        {
            var x = dept.GetAll();
            return View(x);
        }
    }
}
