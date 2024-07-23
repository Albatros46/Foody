using Microsoft.AspNetCore.Mvc;

namespace Foody.WebUI.ViewComponents.AdminLayoutViewComponent
{
	public class _HeadLayoutComponentPartial:ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
			return View();
		}
	}
}
