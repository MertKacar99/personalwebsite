using Microsoft.AspNetCore.Mvc;

namespace PortfolioWeb.Controllers
{
    public class CertificatesController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}