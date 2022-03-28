using Microsoft.AspNetCore.Mvc;
using AtendimentoWeb_Model.Classes;
using System.Collections.Generic;

namespace AtendimentoWeb_App.Controllers
{
    public class UsuariosController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
