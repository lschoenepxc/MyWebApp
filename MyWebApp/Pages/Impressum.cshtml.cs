using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class ImpressumModel : PageModel
{
    private readonly ILogger<ImpressumModel> _logger;

    public ImpressumModel(ILogger<ImpressumModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string dateTime = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("en-US"));
        ViewData["TimeStamp"] = dateTime;
    }
}


