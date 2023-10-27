using DesafioDersenvUsuario.Dominio.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioDesenvUsuario.Service.Servico.Interface
{
    public interface IUsuarioServico
    {
        void Adicionar(Usuario usuario);

        Usuario LogarSistema(Usuario usuario);

        Usuario ListarPorId(int id);
    }
}
