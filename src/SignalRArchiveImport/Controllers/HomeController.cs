using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR.Infrastructure;
using SignalRArchiveImport.Infra;
using System;
using System.Threading;

namespace SignalRArchiveImport.Controllers
{
    public class HomeController : Controller
    {
        IConnectionManager _connectionManager;
        public HomeController(IConnectionManager connectionManager)
        {
            _connectionManager = connectionManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Import()
        {
            return View();
        }

        [HttpPost]
        public JsonResult PostFile(string connectionId)
        {
            var contextHub = _connectionManager.GetHubContext<ProgressHub>();
            contextHub.Clients.Client(connectionId).initProgressBar();
            for (int i = 0; i <= 100; i++)
            {
                contextHub.Clients.Client(connectionId).updateProgressBar(i);
                Thread.Sleep(100);
            }
            contextHub.Clients.Client(connectionId).clearProgressBar();

            return Json("ok");
        }



        public IActionResult Error()
        {
            return View();
        }
    }
}
