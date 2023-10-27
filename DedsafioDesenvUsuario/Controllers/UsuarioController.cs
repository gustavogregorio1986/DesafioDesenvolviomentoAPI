using DedsafioDesenvUsuario.Models;
using DesafioDersenvUsuario.Dominio.Dominio;
using DesafioDesenvUsuario.Service.Servico.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DedsafioDesenvUsuario.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioServico _usuarioServico;

        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        public IActionResult CadastrarUsuario()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CadastrarUsuario(UsuarioModel usuarioModel)
        {
            Usuario usuario = new Usuario();
            usuarioModel = new UsuarioModel()
            {
                IdUsuario = usuario.IdUsuario,
                Login = usuario.Login,
                Senha = usuario.Senha
            };

            _usuarioServico.Adicionar(usuario);
            return View("CadastrarUsuario");
        }

        public IActionResult LogarUsuario(UsuarioModel usuarioModel)
        {
            if(usuarioModel.Login != null)
            {
                return View("CadastraLivro");
            }
            else
            {
                return View("LogarUsuario");
            }
            return View();
        }
    }
}
