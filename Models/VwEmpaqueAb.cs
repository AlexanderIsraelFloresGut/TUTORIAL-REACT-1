using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEmpaqueAb
    {
        public int Empaque { get; set; }
        public string Cliente { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string NombreArticulo { get; set; } = null!;
        public long OrdenProduccion { get; set; }
        public decimal PesoNeto { get; set; }
        public decimal PesoBruto { get; set; }
        public decimal Pescados { get; set; }
        public string Empresa { get; set; } = null!;
    }
}
