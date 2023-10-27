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
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly BancoContexto _db;

        public UsuarioRepositorio(BancoContexto db)
        {
            _db = db;
        }

        public void Adicionar(Usuario usuario)
        {
            _db.Set<Usuario>().Add(usuario);
            _db.SaveChanges();
        }

        public Usuario ListarPorId(int id)
        {
            return _db.Set<Usuario>().FirstOrDefault(model => model.IdUsuario == id);
        }

        public Usuario LogarSistema(Usuario usuario)
        {
            return _db.Set<Usuario>().FirstOrDefault(model => model.IdUsuario == usuario.IdUsuario);
        }
    }
}
