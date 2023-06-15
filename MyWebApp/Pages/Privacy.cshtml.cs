using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyWebApp.Pages;

public class PrivacyModel : PageModel
{
    private readonly ILogger<PrivacyModel> _logger;

    public PrivacyModel(ILogger<PrivacyModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        string dateTime = DateTime.Now.ToString("dddd, dd MMMM yyyy", new CultureInfo("en-US"));
        ViewData["TimeStamp"] = dateTime;
    }
}


