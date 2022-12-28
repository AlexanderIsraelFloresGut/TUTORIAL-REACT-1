using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VOrdenProduccionLiberadum
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Estructura { get; set; } = null!;
        public string Version { get; set; } = null!;
        public DateTime? FechaLiberacion { get; set; }
        public string Operacion { get; set; } = null!;
        public string OperacionDesc { get; set; } = null!;
        public short? Secuencia { get; set; }
        public string Articulo { get; set; } = null!;
        public string ArticuloDesc { get; set; } = null!;
        public decimal PesoNeto { get; set; }
        public string UnidadAlmacen { get; set; } = null!;
        public string? Clasificacion1 { get; set; }
        public string? Clasificacion2 { get; set; }
        public string? Clasificacion3 { get; set; }
        public string? Clasificacion4 { get; set; }
        public string? Clasificacion5 { get; set; }
        public string? Clasificacion6 { get; set; }
    }
}
