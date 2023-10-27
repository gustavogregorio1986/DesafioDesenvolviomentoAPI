using DesafioDersenvUsuario.Dominio.Dominio;
using DesafioDesenvUsuario.Data.Contexto;
using DesafioDesenvUsuario.Data.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDesenvUsuario.Data.Repositorio
{
    public class LivroRepositorio : ILivroRepositorio
    {
        private readonly BancoContexto _db;

        public LivroRepositorio(BancoContexto db)
        {
            _db = db;
        }

        public void AdicionarLivro(Livro livro)
        {
            _db.Set<Livro>().Add(livro);
            _db.SaveChanges();
        }

        public List<Livro> ListarLivros()
        {
            return _db.Set<Livro>().ToList();
        }
    }
}
