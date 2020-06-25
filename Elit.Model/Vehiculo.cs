using System;
using System.Collections.Generic;
using System.Text;

namespace Elit.Model
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public int MarcaId { get; set; }
        public string DescripcionMarca { get; set; }
        public string DescripcionModelo { get; set; }
        public int TipoVehiculoId { get; set; }
        public string DescripcionVehiculo { get; set; }
        public Marca Marca { get; set; }
        public TipoVehiculo TipoVehiculo { get; set; }
    }
}
