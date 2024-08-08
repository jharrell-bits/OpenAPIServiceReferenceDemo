using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OpenAPIDemo.WidgetWebAPI;
using System.Net.Http;

namespace OpenAPIDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _httpClient;

        public List<Widget> Widgets { get; set; } = new List<Widget>();

        public IndexModel(ILogger<IndexModel> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task OnGetAsync()
        {
            var widgetAPI = new WidgetWebAPI.WidgetWebAPI("https://localhost:44325", _httpClient);

            Widgets = (await widgetAPI.GetWidgetsAsync()).ToList();
        }
    }
}
