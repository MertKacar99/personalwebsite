using Microsoft.AspNetCore.Mvc;

namespace PortfolioWeb.Controllers
{
    public class ContactController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}