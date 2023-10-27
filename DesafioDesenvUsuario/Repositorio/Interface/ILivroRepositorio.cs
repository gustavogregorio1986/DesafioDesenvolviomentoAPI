using DesafioDersenvUsuario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDesenvUsuario.Data.Repositorio.Interface
{
    public interface ILivroRepositorio
    {
        void AdicionarLivro(Livro livro);

        List<Livro> ListarLivros();
    }
}
