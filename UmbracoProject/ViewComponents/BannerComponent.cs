using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoProject
{
	[ViewComponent(Name = "BannerContent")]
	public class BannerComponent : ViewComponent
	{
		public IViewComponentResult Invoke(object banner)
		{
			return View("_CarouselView", banner);
		}
	}
}
