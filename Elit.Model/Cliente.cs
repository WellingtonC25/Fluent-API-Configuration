using System;
using System.Collections.Generic;
using System.Text;

namespace Elit.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string Direccion { get; set; }
        public string Contacto { get; set; }
        public string Correo { get; set; }
        public Master Master { get; set; }
    }
}
