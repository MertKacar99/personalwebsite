using Microsoft.AspNetCore.Mvc;

namespace PortfolioWeb.Controllers
{
    public class ReferencesController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}