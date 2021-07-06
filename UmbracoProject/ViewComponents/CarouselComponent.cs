using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoProject
{
	[ViewComponent(Name = "CarouselContent")]
	public class CarouselComponent : ViewComponent
	{
		public IViewComponentResult Invoke(object carousel)
		{
			return View("_CarouselView", carousel);
		}
	}
}
