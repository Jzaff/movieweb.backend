using Microsoft.AspNetCore.Mvc;
using moviewebsite.DAL.EF.Abstract;

namespace moviewebsite.WebUI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryRepository db;

        public CategoryController(ICategoryRepository db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            var list = db.FindAllAsync();
            return View(list);
        }
    }
}
