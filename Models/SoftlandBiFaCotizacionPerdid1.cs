using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiFaCotizacionPerdid1
    {
        public string Cotizacion { get; set; } = null!;
        public string Cliente { get; set; } = null!;
        public string? NombreCliente { get; set; }
        public string? Rubro1 { get; set; }
        public string? Rubro2 { get; set; }
        public string? Rubro3 { get; set; }
        public string? Rubro4 { get; set; }
        public string? Rubro5 { get; set; }
        public string? RazonCancelacion { get; set; }
        public string? DescripcionCancelacion { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        public decimal TotalCotizacion { get; set; }
    }
}
