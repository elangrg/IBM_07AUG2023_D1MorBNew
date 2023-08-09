using Microsoft.AspNetCore.Razor.TagHelpers;

namespace IBM_07AUG2023_D1MorBNew.Infra
{

    [HtmlTargetElement("greet-tag-helper")]
    public class GreetTagHelper : TagHelper
    {
        public string Name
        {
            get;
            set;
        }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.PreContent.SetHtmlContent($"<h1>Hi {this.Name} , Greeting from Custom Tag Helper! </h1>");

        }
    }
}
