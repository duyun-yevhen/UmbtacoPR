using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoProject
{
	[ViewComponent(Name = "CarouselContent")]
	public class CarouselComponent : ViewComponent
	{
		public IViewComponentResult Invoke(IPublishedElement video)
		{
			return View("_CarouselView", video);
		}
	}
}
