using Microsoft.AspNetCore.Mvc;

namespace Foody.WebUI.ViewComponents.AdminLayoutViewComponent
{
	public class _FooterComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
