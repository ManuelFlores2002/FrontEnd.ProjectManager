namespace ProyectManager.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public int IdProyecto { get; set; }
        public int IdUsuario { get; set; }
        public byte Estado { get; set; }
    }
}
