using DesafioDersenvUsuario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDesenvUsuario.Data.Repositorio.Interface
{
    public interface IUsuarioRepositorio
    {
        void Adicionar(Usuario usuario);

        Usuario LogarSistema(Usuario usuario);

        Usuario ListarPorId(int id);
    }
}
