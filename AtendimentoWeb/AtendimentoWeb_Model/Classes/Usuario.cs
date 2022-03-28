using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoWeb_Model.Classes
{
    public class Usuario
    {
        [DisplayName("Id")]
        public long UsuarioId { get; set; }
        public string Nome { get; set; }
        public Usuario CriadoPor { get; set; }
        public Usuario ModificadoPor { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataModificaco { get; set; }
        public bool Ativo { get; set; } = true;

    }
}
