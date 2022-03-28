using System;

namespace AtendimentoWeb_Model.Classes
{
    public class Chamado
    {
        public long ChamadoId { get; set; }
        public string Ticket {
            get
            {
                return ChamadoId.ToString("#0000");
            }
        }

        public string Status { get; set; }
        public string Descricao { get; set; }
        public DateTime DatacCriacao { get; set; } = DateTime.Now;
        public Assunto Assunto { get; set; }
        public Cliente Cliente { get; set; }
        public Atendente Atendente { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string CEP { get; set; }
        public Usuario CriadoPor { get; set; }
        public Usuario ModificadoPor { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime DataModificaco { get; set; } = DateTime.UtcNow;
        public bool Ativo { get; set; } = true;
    }
}
