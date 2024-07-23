using Microsoft.AspNetCore.Mvc;

namespace Foody.WebUI.ViewComponents.AdminLayoutViewComponent
{
	public class _MainPanelComponenPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
