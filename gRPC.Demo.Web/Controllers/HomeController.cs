using gRPC.Demo.Web.Models;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace gRPC.Demo.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new RegistrationViewModel();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Register(RegistrationViewModel model)
        {
            if(ModelState.IsValid)
            {
                var channel = GrpcChannel.ForAddress("https://localhost:7034");
                var client = new DataProcessor.DataProcessorClient(channel);

                var reply = await client.ProcessRegistrationAsync(new RegistrationRequest() { 
                    BusinessName = model.BusinessName,
                    Firstname = model.FirstName,
                    Lastname = model.LastName,
                    IsActive = model.IsActive,
                    YearsInBusiness = model.YearsInBusiness
                });

                return View("Register", reply);
            }

            return View("Index", ModelState);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}