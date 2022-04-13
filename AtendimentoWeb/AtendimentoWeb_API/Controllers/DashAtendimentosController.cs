using AtendimentoWeb_Model.Interdace;
using AtendimentoWeb_Model.Models;
using AtendimentoWeb_Model.Relatorios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace AtendimentoWeb_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DashAtendimentosController : ControllerBase, IEndpointPadrao<DashAtendimentos>
    {

        private DashAtendimentoModel DashAtendimentoModel() => new DashAtendimentoModel();

        [HttpDelete]
        public void Delete(long id)
        {
            throw new System.NotImplementedException();
        }

        [HttpGet]
        public DashAtendimentos Get(long? id = null)
        {
            return DashAtendimentoModel().Consultar();
        }

        /*
        [HttpGet("All")]
        public List<string> GetList()
        {
            throw new System.NotImplementedException();
        }

        [HttpPatch]
        public void Path(long id, string value)
        {
            throw new System.NotImplementedException();
        }

        [HttpPost]
        public string Post()
        {
            throw new System.NotImplementedException();
        }

        [HttpPut]
        public void Put(long id, string value)
        {
            throw new System.NotImplementedException();
        }*/
    }
}
