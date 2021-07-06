using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UmbracoProject
{
	[ViewComponent(Name = "VideoContent")]
	public class VideoComponent : ViewComponent
	{
		public IViewComponentResult Invoke(IPublishedElement video)
		{
			return View("_VideoView", video);
		}
	}
}
