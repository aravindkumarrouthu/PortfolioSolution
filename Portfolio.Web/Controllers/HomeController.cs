using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Web.Models;

namespace Portfolio.Web.Controllers
{
    public class HomeController : Controller
    {
		public IActionResult Projects()
		{
			return View();
		}
		public IActionResult Resume()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}

		public IActionResult Skills()
		{
			return View();
		}

		public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
		[HttpGet]
		public IActionResult Contact()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Contact(string name, string email, string message)
		{
			ViewBag.Success = "Thank you! Your message has been sent successfully.";
			return View();
		}


		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
