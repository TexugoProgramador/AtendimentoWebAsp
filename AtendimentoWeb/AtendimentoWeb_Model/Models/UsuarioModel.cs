using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AtendimentoWeb_Model.Classes;
using AtendimentoWeb_Model.Negocio;

namespace AtendimentoWeb_Model.Models
{
    public class UsuarioModel: UsuarioBusiness
    {
        public List<Usuario> ConsultarListaUsuarios(bool isPodeConsultar)
        {

            try
            {
                List<Usuario> Lista = new List<Usuario>()
                {
                    new Usuario()
                    {
                        UsuarioId = 1,
                        Nome = "Nome 1",
                        Ativo = true
                    },
                    new Usuario()
                    {
                        UsuarioId = 2,
                        Nome = "Nome 2",
                        Ativo = false
                    },
                    new Usuario()
                    {
                        UsuarioId = 3,
                        Nome = "Nome 3",
                        Ativo = true
                    },
                    new Usuario()
                    {
                        UsuarioId = 4,
                        Nome = "Nome 4",
                        Ativo = false
                    },
                    new Usuario()
                    {
                        UsuarioId = 5,
                        Nome = "Nome 5",
                        Ativo = true
                    }
                };
                return Lista.Where(a=> a.Ativo = isPodeConsultar).ToList();
            }
            catch (Exception)
            {

                throw;
            }

            /*
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
            */
            }
    }
    }
