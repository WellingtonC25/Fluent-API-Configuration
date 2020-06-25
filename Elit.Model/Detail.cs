using System;
using System.Collections.Generic;
using System.Text;

namespace Elit.Model
{
    public class Detail
    {
        public int Codigo { get; set; }
        public Guid MasterId { get; set; }
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string TVDescripcion { get; set; }
        public string Lavado { get; set; }
        public double Precio { get; set; }
        public double SubTotal { get; set; }
        public double ITBIS { get; set; }
        public double Total { get; set; }
        public Master Master { get; set; }
        public List<Vehiculo> Vehiculos { get; set; }
        public List<TipoLavado> Lavados { get; set; }
    }
}
