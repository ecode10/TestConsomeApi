using CallApi.Library;
using CallApi.Library.Util;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TestConsomeAPI.Model;

namespace TestConsomeAPI.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public async Task OnGet()
    {
        CallApi.Library.Main _main = new Main();
        var result = await _main.ExecuteCall<List<WeatherForecastModel>>("https://localhost:7036", 
                                        "/WeatherForecast", 
                                        CallType.GET,
                                        null, 
                                        null, 
                                        null, 
                                        null);

        Response.WriteAsync(result.Count().ToString());
        
    }
}