using AtendimentoWeb_Model.Classes;
using AtendimentoWeb_Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AtendimentoWeb_App.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuarioModel UsuarioModel() => new UsuarioModel();

        [HttpGet]
        [Route("usuarios/{nome}/{ativo}")]
        public IActionResult Index(bool ativo = true)
        {
            try
            {
                List<Usuario> ListaUsuarios = UsuarioModel().ConsultarListaUsuarios(isPodeConsultar: ativo);
                return View(ListaUsuarios);
            }
            catch (System.Exception)
            {
                // TODO: salvar log de erro
                throw;
            }
        }
    }
}
