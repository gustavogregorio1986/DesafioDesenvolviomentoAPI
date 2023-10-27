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
    public class LivroServico : ILivroServico
    {
        private readonly ILivroRepositorio _livroRepositorio;

        public LivroServico(ILivroRepositorio livroRepositorio)
        {
            _livroRepositorio = livroRepositorio;
        }

        public void AdicionarLivro(Livro livro)
        {
            _livroRepositorio.AdicionarLivro(livro);
        }

        public List<Livro> ListarLivros()
        {
           return _livroRepositorio.ListarLivros();
        }
    }
}
