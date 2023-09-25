using ProyectManager.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace ProyectManager.Services
{
    public class ColaboradorService : IColaboradorService
    {
        //inyeccion de dependencias de HttpCLient
        private readonly HttpClient _httpClient;
        public ColaboradorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

        public async Task<IEnumerable<Colaborador>> GetAll()
        {
            string resp = await _httpClient.GetStringAsync($"Colaborador");
            return JsonSerializer.Deserialize<IEnumerable<Colaborador>>(resp, options);
        }

        public async Task<IEnumerable<Colaborador>> GetByUsuario(int idUsuario)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Colaborador/Buscar", new { idUsuario = idUsuario });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Colaborador>>(respString, options);
        }
        public async Task<IEnumerable<Colaborador>> GetByProyecto(int idProyecto)
        {
            var resp = await _httpClient.PostAsJsonAsync($"Colaborador/Buscar", new { idProyecto = idProyecto });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Colaborador>>(respString, options);
        }
        public async Task<Colaborador> GetById(int id)
        {
            string resp = await _httpClient.GetStringAsync($"Colaborador/{id}");
            return JsonSerializer.Deserialize<Colaborador>(resp, options);
        }
    }
}
