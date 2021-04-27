using IUGU.Web.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace IUGU.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUGUService _iUGUService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _iUGUService = new IUGUService();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> _GetPix(int valor)
        {
            var response = await _iUGUService.GetPix(valor);
            return PartialView(response);
        }
    }
}
