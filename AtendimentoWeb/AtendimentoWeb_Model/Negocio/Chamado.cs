using System;

namespace AtendimentoWeb_Model.Negocio
{
    public class Chamado
    {
        public int ChamadoId { get; internal set; }
        public string Descricao { get; internal set; }
        public DateTime DataCriacao { get; internal set; }
        public string Status { get; internal set; }
    }
}