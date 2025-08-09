using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace App.TagHelpers
{
    [HtmlTargetElement("bs-input", Attributes = ForAttributeName)]
    public class InputTagHelper : TagHelper
    {
        private const string ForAttributeName = "asp-for";

        [HtmlAttributeName(ForAttributeName)]
        public ModelExpression For { get; set; }

        public string Placeholder { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "input";
            output.TagMode = TagMode.SelfClosing;
            output.Attributes.SetAttribute("type", "text");
            output.Attributes.SetAttribute("name", For.Name);
            output.Attributes.SetAttribute("value", For.Model?.ToString());
            output.Attributes.SetAttribute("class", "form-control");
            if (!string.IsNullOrEmpty(Placeholder))
            {
                output.Attributes.SetAttribute("placeholder", Placeholder);
            }
        }
    }
}
