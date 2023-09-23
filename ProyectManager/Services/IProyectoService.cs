
using ProyectManager.Models;

namespace ProyectManager.Services
{
    public interface IProyectoService
    {
        Task<IEnumerable<Proyecto>> GetAll();
        Task<IEnumerable<Proyecto>> GetByUsuario(int idUsuario);
        Task<Proyecto> GetById(int id);
    }
}
