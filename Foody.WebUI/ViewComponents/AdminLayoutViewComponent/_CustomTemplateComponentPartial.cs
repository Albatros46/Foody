using Microsoft.AspNetCore.Mvc;

namespace Foody.WebUI.ViewComponents.AdminLayoutViewComponent
{
	public class _CustomTemplateComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
