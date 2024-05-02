using Microsoft.AspNetCore.Mvc;

namespace MyPortfolio.ViewComponents.LayoutViewComponent
{
	public class LayoutHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke() 
		{
			return View(); 
		}
	}
}
