using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtendimentoWeb_Model.Classes
{
    public class Cliente
    {
        public long ClienteId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string NomeSocial { get; set; }
        public string Apelido { get; set; }
        public string Cpf { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Email { get; set; }
        public string Celular { get; set; }
        public bool EhWhatsapp { get; set; }
        public Usuario Usuario { get; set; }
        public Usuario CriadoPor { get; set; }
        public Usuario ModificadoPor { get; set; }
        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;
        public DateTime DataModificaco { get; set; } = DateTime.UtcNow;
        public bool Ativo { get; set; } = true;
    }
}
