using AtendimentoWeb_Model.Negocio;
using AtendimentoWeb_Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace AtendimentoWeb_App.Controllers
{
    public class ChamadosController : Controller
    {

        private ChamadoModel ChamadoModel() => new ChamadoModel();

        [HttpGet]
        public IActionResult Index()
        {
            List<Chamado> ListaChamados = ChamadoModel().ConsultarListaEmAberto();
            return View(ListaChamados);
        }
    }
}
