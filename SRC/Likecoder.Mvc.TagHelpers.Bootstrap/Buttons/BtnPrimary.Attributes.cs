using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace Likecoder.Mvc.TagHelpers.Bootstrap.Buttons
{
	using S = String;

	[HtmlTargetElement("button", Attributes = "btn-primary")]
	[HtmlTargetElement("a", Attributes = "btn-primary")]
	public class BtnPrimaryAttributes : TagHelper
	{
		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			var existsClass = output.Attributes["class"]?.Value?.ToString() ?? S.Empty;
			if (existsClass.IsFalse() || existsClass.Contains("btn-primary"))
			{
				output.Attributes.SetAttribute("class", $"btn btn-primary {existsClass}");
			}
		}

	}
}
