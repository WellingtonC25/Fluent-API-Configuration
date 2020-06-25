using System;
using System.Collections.Generic;
using System.Text;

namespace Elit.Model
{
    public class Master
    {
        public Guid Codigo { get; set; } = Guid.NewGuid();
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public string NombreCliente { get; set; }
        public int EmpleadoId { get; set; }
        public string NombreEmpleado { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public List<Detail> Details { get; set; }
    }
}
