using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace Likecoder.Mvc.TagHelpers.Bootstrap.Buttons
{
	using S = String;

	public class BtnPrimary : TagHelper
	{
		public string CssClass { get; set; } = S.Empty;
		public string Id { get; set; } = S.Empty;
		public string Name { get; set; } = S.Empty;
		public bool IsDisabled { get; set; }


		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.Attributes.SetAttribute("id", Id);
			output.Attributes.SetAttribute("name", Name);
			output.Attributes.SetAttribute("class", $"btn btn-primary {CssClass}");
			if (IsDisabled)
			{
				output.Attributes.SetAttribute("disabled", "disabled");
			}

		}

	}
}
