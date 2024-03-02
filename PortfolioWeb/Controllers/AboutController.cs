using Microsoft.AspNetCore.Mvc;

namespace PortfolioWeb.Controllers
{
    public class AboutController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}