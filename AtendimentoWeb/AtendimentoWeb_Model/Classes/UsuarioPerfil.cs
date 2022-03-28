using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoWeb_Model.Classes
{
    public class UsuarioPerfil
    {
        public long UsuarioPerfilId { get; set; }
        public Perfil Perfil { get; set; }
        public Usuario Usuario { get; set; }
        public Usuario CriadoPor { get; set; }
        public Usuario ModificadoPor { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime DataModificaco { get; set; } = DateTime.UtcNow;
        public bool Ativo { get; set; } = true;
    }
}
