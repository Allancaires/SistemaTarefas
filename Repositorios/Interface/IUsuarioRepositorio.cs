using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaTarefas.Repositorios.Interface
{
    public interface IUsuarioRepositorio
    {
        Task<List<Models.UsuarioModel>> BuscarTodosUsuarios();
        Task<Models.UsuarioModel> BuscarPorId(int id);
        Task<Models.UsuarioModel> AdicionarUsuario(Models.UsuarioModel usuario);
        Task<Models.UsuarioModel> AtualizarUsuario(Models.UsuarioModel usuario, int id);
        Task<bool> ApagarUsuario(int id);

    }
}