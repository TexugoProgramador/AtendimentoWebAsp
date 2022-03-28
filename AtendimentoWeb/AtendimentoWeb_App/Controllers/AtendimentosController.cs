using Microsoft.AspNetCore.Mvc;

namespace AtendimentoWeb_App.Controllers
{
    public class AtendimentosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
