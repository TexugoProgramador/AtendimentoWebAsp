using Microsoft.AspNetCore.Mvc;
using AtendimentoWeb_Model.Models;
using AtendimentoWeb_Model.Relatorios;

namespace AtendimentoWeb_App.Controllers
{
    public class AdminController : Controller
    {

        private DashAtendimentoModel DashAtendimentoModel() => new DashAtendimentoModel();

        [HttpGet]
        public IActionResult Index()
        {
            DashAtendimentos DashAtendimentosResponse = DashAtendimentoModel().Consultar();
            //ViewData["VariavelTotal"] = "1";
            //ViewData["VariavelAberto"] = "2";
            //ViewData["VariavelFinalizados"] = "3";
            return View(DashAtendimentosResponse);
        }
    }
}
