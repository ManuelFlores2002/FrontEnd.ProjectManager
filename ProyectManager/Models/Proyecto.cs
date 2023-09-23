using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectManager.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public int IdAdministrador { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Estado { get; set; }
    }
}
