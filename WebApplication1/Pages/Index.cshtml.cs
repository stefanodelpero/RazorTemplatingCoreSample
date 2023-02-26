using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor.Templating.Core;

namespace WebApplication1.Pages;

public class IndexModel : PageModel
{
    public string Html { get; set; } = string.Empty;

    public async Task OnGetAsync()
    {
        Html = await RazorTemplateEngine.RenderAsync("Pages/Template.cshtml");
    }
}