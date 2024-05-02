using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponent
{
	public class LayoutSidebarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke() {  return View(); }
	}
}
