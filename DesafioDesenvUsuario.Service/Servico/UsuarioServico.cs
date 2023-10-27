using DesafioDersenvUsuario.Dominio.Dominio;
using DesafioDesenvUsuario.Data.Repositorio.Interface;
using DesafioDesenvUsuario.Service.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDesenvUsuario.Service.Servico
{
    public class UsuarioServico : IUsuarioServico
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioServico(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public void Adicionar(Usuario usuario)
        {
            _usuarioRepositorio.Adicionar(usuario);
        }

        public Usuario ListarPorId(int id)
        {
            return _usuarioRepositorio.ListarPorId(id);
        }

        public Usuario LogarSistema(Usuario usuario)
        {
            try
            {
                Usuario usuarioLogado = _usuarioRepositorio.ListarPorId(usuario.IdUsuario);
                if (usuarioLogado != null)
                {
                    usuarioLogado.Login = usuario.Login;
                    usuarioLogado.Senha = usuario.Senha;
                }
                else
                {
                    throw new Exception("Usuario não logado com sucesso!");
                }

                return usuarioLogado;
            }
            catch (Exception ex)
            {

                throw new Exception("Erro: " + ex.Message);
            }
        }
    }
}
