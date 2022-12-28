using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwEdoctaBcf
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public DateTime FechaDocumento { get; set; }
        public string Proveedor { get; set; } = null!;
        public string? NombreProveedor { get; set; }
        public string Contribuyente { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string TipoDc { get; set; } = null!;
        public string Documento { get; set; } = null!;
        public string? Aplicacion { get; set; }
        public decimal? MontoNio { get; set; }
        public decimal? MontoUsd { get; set; }
        public decimal? SaldoNio { get; set; }
        public decimal? SaldoDolar { get; set; }
    }
}
