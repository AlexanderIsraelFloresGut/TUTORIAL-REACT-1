using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCoResumenCompra1
    {
        public string OrdenCompra { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string? Estado { get; set; }
        public string Moneda { get; set; } = null!;
        public string Pais { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public int? AnoFecha { get; set; }
        public int? MesFecha { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? TotalMercaderiaLocal { get; set; }
        public decimal? TotalMercaderiaDolar { get; set; }
    }
}
