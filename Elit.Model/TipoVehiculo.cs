using System;
using System.Collections.Generic;
using System.Text;

namespace Elit.Model
{
    public class TipoVehiculo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
    }
}
