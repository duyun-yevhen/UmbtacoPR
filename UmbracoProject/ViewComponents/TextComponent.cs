using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Models.PublishedContent;

namespace UmbracoProject
{
	[ViewComponent(Name = "TextContent")]
	public class TextComponent : ViewComponent
	{
		public IViewComponentResult Invoke(object text)
		{
			return View("_TextView", text);
		}
	}
}
