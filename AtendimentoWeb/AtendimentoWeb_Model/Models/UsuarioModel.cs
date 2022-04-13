using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtendimentoWeb_Model.Classes;
using AtendimentoWeb_Model.Negocio;

namespace AtendimentoWeb_Model.Models
{
    public class UsuarioModel : UsuarioBusiness
    {

        public Usuario Consultar(long id, bool? ativo = true, string nome = "")
        {
            return ConsultarListaUsuarios(ativo, nome).Where(a=> a.UsuarioId == id).FirstOrDefault();
        }
        
        public List<Usuario> ConsultarListaUsuarios(bool? ativo = null, string nome = "")
        {
        
            List<Usuario> ListaUsuarios = new List<Usuario>();
            ListaUsuarios.Add(new Usuario() { UsuarioId = 1, Nome = "Nome 1", Ativo = true });
            ListaUsuarios.Add(new Usuario() { UsuarioId = 2, Nome = "Nome 2", Ativo = false });
            ListaUsuarios.Add(new Usuario() { UsuarioId = 3, Nome = "Nome 3", Ativo = true });
            ListaUsuarios.Add(new Usuario() { UsuarioId = 4, Nome = "Nome 4", Ativo = false });
            ListaUsuarios.Add(new Usuario() { UsuarioId = 5, Nome = "Nome 5", Ativo = true });
        
            if (ativo != null)
            {
                ListaUsuarios = ListaUsuarios.Where(a => a.Ativo == ativo.Value).ToList();
            } 
        
            if (!string.IsNullOrEmpty(nome))
            {
               ListaUsuarios = ListaUsuarios.Where(a => a.Nome.ToLower().Contains(nome.ToLower()) ).ToList();
            }
        
            return ListaUsuarios;
        }
    }
}