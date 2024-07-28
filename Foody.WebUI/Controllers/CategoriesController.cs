using Foody.Business.Abstract;
using Foody.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Foody.WebUI.Controllers
{
	public class CategoriesController : Controller
	{
		private readonly ICategoryService _service;

		public CategoriesController(ICategoryService service)
		{
			_service = service;
		}

		public IActionResult CategoryList()
		{
			var values = _service.TGetAll();
			return View(values);
		}

		[HttpGet]
		public IActionResult Create() 
		{
			return View();
		}

        [HttpPost]
        public IActionResult Create(Category category)
        {
			_service.TInsert(category);
            return RedirectToAction("CategoryList");
        }
    }
}
