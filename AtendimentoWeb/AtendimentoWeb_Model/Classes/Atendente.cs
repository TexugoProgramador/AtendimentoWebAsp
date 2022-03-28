using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoWeb_Model.Classes
{
    public class Atendente
    {
        public long AtendenteId { get; set; }
        public string Nome { get; set; }
        public Unidade Unidade { get; set; }
        public Usuario Usuario { get; set; }
        public Usuario CriadoPor { get; set; }
        public Usuario ModificadoPor { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificaco { get; set; }
        public bool Ativo { get; set; } = true;
    }
}
