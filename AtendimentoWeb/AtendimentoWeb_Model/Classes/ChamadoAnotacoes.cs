using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoWeb_Model.Classes
{
    public class ChamadoAnotacoes
    {
        public long ChamadoAnotacaoID { get; set; }
        public String Texto { get; set; }
        public Chamado Chamado { get; set; }
        public UsuarioPerfil UsuarioPerfil { get; set; }
        public Usuario CriadoPor { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public bool Ativo { get; set; } = true;
    }
}
