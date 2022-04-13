using AtendimentoWeb_Model.Classes;
using AtendimentoWeb_Model.Interdace;
using AtendimentoWeb_Model.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AtendimentoWeb_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController : Controller
    {

        //public UsuarioModel UsuarioModel() => new UsuarioModel();

        [HttpGet]
        public Usuario Get(long id, bool? ativo = null, string nome = "")
        {
            //return UsuarioModel().Consultar(id, ativo, nome);
            return new UsuarioModel().Consultar(id, ativo, nome);
        }
       
        [HttpGet("All")]
        public List<Usuario> GetList(bool ativo, string nome)
        {
            return new UsuarioModel().ConsultarListaUsuarios(ativo, nome);
        }

        [HttpDelete]
        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        [HttpPatch]
        public void Path(long id, Usuario value)
        {
            throw new System.NotImplementedException();
        }

        [HttpPost]
        public string Post()
        {
            throw new System.NotImplementedException();
        }

        [HttpPut]
        public void Put(long id, Usuario value)
        {
            throw new System.NotImplementedException();
        }
    }
}