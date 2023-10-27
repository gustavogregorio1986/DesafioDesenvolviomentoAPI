using DedsafioDesenvUsuario.Models;
using DesafioDersenvUsuario.Dominio.Dominio;
using DesafioDesenvUsuario.Service.Servico.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DedsafioDesenvUsuario.Controllers
{
    public class LivroController : Controller
    {
        private readonly ILivroServico _livroServico;

        public LivroController(ILivroServico livroServico)
        {
            _livroServico = livroServico;
        }

        public IActionResult CadastrarLivro()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult CadastrarLivro(LivroModel livroModel)
        {
            Livro livro = new Livro();
            if (!ModelState.IsValid)
            {
                livroModel = new LivroModel() {
                    IdLivro = livroModel.IdLivro,
                    Genero = livroModel.Genero,
                    Autor = livroModel.Autor
                };

                _livroServico.AdicionarLivro(livro);

            }
            return View("CadatsrarLivro");
        }
    }
}
