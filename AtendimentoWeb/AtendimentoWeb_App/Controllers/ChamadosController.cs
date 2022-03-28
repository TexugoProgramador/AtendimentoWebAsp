using AtendimentoWeb_Model.Classes;
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
            // ARRUMAR AQUI
            //return View(ChamadoModel().ConsultarListaEmAberto());
            List<Chamado> ListaChamados = ChamadoModel().ConsultarListaEmAberto();
            return View(ListaChamados);
        }
    }
}
