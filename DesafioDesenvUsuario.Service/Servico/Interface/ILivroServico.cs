using DesafioDersenvUsuario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDesenvUsuario.Service.Servico.Interface
{
    public interface ILivroServico
    {
        void AdicionarLivro(Livro livro);

        List<Livro> ListarLivros();
    }
}
