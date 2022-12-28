using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwMermaCompraMpb
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? Dia { get; set; }
        public DateTime FechaOc { get; set; }
        public string OrdenCompra { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string? Descripcion { get; set; }
        public decimal Libras { get; set; }
        public decimal? MontoCompra { get; set; }
        public decimal MermaAplicada { get; set; }
        public decimal? Neto { get; set; }
    }
}
