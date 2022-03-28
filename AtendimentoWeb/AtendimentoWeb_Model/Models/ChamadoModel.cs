using System;
using System.Collections.Generic;
using AtendimentoWeb_Model.Classes;
using AtendimentoWeb_Model.Negocio;

namespace AtendimentoWeb_Model.Models
{
    public class ChamadoModel: ChamadoBusines
    {

        public List<Chamado> ChamadoListaFinalizadosHoje()
        {
            throw new NotImplementedException();
        }
        public List<Chamado> ChamadoLista()
        {
            throw new NotImplementedException();
        }

        public List<Chamado> ChamadoPorId(long ChamadoId)
        {
            throw new NotImplementedException();
        }

        public  List<Chamado> ConsultarListaEmAberto()
        {
            List<Chamado> Lista = new List<Chamado>()
            {
                new Chamado()
                {
                    ChamadoId = 1,
                    Descricao = "Teste ",
                    DataCriacao = new DateTime(2022, 03, 24),
                    Status = "Em Aberto"
                }
            };           
            return Lista;
         }
    }
}
