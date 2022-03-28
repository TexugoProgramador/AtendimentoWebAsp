using AtendimentoWeb_Model.Relatorios;
using AtendimentoWeb_Model.Negocio;

namespace AtendimentoWeb_Model.Models
{
    public class DashAtendimentoModel : DashAtendimentoBusines
    {
        public DashAtendimentos Consultar()
        {
            return new DashAtendimentos()
            {
                EmbAberto = 5,
                Finalizados = 6,
                Total = 11
            };
    }
}
}
