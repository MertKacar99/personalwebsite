using Microsoft.AspNetCore.Mvc;

namespace PortfolioWeb.Controllers
{
    public class BlogController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}