using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApplication1;

[HtmlTargetElement("webrootpath")]
public class WebRootPathTagHelper : TagHelper
{
    private readonly IWebHostEnvironment _environment;

    public WebRootPathTagHelper(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagName = "div";
        output.Content.AppendHtml(_environment.WebRootPath);
    }
}
