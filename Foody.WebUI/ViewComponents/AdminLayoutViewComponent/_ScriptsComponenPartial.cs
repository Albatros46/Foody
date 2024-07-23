using Microsoft.AspNetCore.Mvc;

namespace Foody.WebUI.ViewComponents.AdminLayoutViewComponent
{
	public class _ScriptsComponenPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
