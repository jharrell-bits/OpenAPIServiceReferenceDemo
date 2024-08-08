using Microsoft.AspNetCore.Mvc;

namespace WidgetWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WidgetController : ControllerBase
    {
        private readonly ILogger<WidgetController> _logger;

        public WidgetController(ILogger<WidgetController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWidgets")]
        public IEnumerable<Widget> Get()
        {
            return new List<Widget>()
            {
                new Widget()
                {
                    Id = 1,
                    Name = "Widget1",
                    Description = "Widget 1",
                    Price = 1m
                },
                new Widget()
                {
                    Id = 2,
                    Name = "Widget2",
                    Description = "Widget 2",
                    Price = 10m
                },
                new Widget()
                {
                    Id = 3,
                    Name = "Widget3",
                    Description = "Widget 3",
                    Price = 100m
                }
            }.ToArray();
        }
    }
}
