using ProyectManager.Models;

namespace ProyectManager.Services
{
    public interface IColaboradorService
    {
        Task<IEnumerable<Colaborador>> GetAll();
        Task<IEnumerable<Colaborador>> GetByUsuario(int idUsuario);
        Task<IEnumerable<Colaborador>> GetByProyecto(int idProyecto);
        Task<Colaborador> GetById(int id);
    }
}
