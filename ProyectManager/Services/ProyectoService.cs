using ProyectManager.Models;
using System.Net.Http.Json;
using System.Text.Json;

namespace ProyectManager.Services
{
    public class ProyectoService : IProyectoService
    {
        //inyección de dependencias de HttpClient
        private readonly HttpClient client;
        public ProyectoService(HttpClient httpClient)
        {
            client = httpClient;
        }

        //configurar las opciones del Serializador
        JsonSerializerOptions options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };


        public async Task<IEnumerable<Proyecto>> GetAll()
        {
            string resp = await client.GetStringAsync($"Proyecto");
            return JsonSerializer.Deserialize<IEnumerable<Proyecto>>(resp, options);
       
        }

        public async Task<IEnumerable<Proyecto>> GetByUsuario(int idUsuario)
        {
            var resp = await client.PostAsJsonAsync($"Proyecto/Buscar", new { idAdministrador = idUsuario });
            string respString = await resp.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<IEnumerable<Proyecto>>(respString, options);
        }
        public async Task<Proyecto> GetById(int id)
        {
            string resp = await client.GetStringAsync($"Proyecto/{id}");
            return JsonSerializer.Deserialize<Proyecto>(resp, options);
        }
    }

}
