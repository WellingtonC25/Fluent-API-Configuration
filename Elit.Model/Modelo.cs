using System;
using System.Collections.Generic;
using System.Text;

namespace Elit.Model
{
    public class Modelo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
    }
}
