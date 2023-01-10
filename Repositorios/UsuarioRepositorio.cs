using SistemaTarefas.Data;
using SistemaTarefas.Models;
using SistemaTarefas.Repositorios.Interface;

namespace SistemaTarefas.Repositorios
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        public UsuarioRepositorio(SistemaTarefasDbContext sistemaTarefasDbContext)
        {
            
        }
        Task<UsuarioModel> IUsuarioRepositorio.AdicionarUsuario(UsuarioModel usuario)
        {
            throw new NotImplementedException();
        }

        Task<bool> IUsuarioRepositorio.ApagarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        Task<UsuarioModel> IUsuarioRepositorio.AtualizarUsuario(UsuarioModel usuario, int id)
        {
            throw new NotImplementedException();
        }

        Task<UsuarioModel> IUsuarioRepositorio.BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        Task<List<UsuarioModel>> IUsuarioRepositorio.BuscarTodosUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}