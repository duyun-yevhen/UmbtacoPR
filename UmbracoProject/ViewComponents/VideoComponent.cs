using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoProject
{
	[ViewComponent(Name = "VideoContent")]
	public class VideoComponent : ViewComponent
	{
		public IViewComponentResult Invoke(object video)
		{
			return View("_VideoView", video);
		}
	}
}
