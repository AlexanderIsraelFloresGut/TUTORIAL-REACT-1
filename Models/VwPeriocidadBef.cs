using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class VwPeriocidadBef
    {
        public string Embarque { get; set; } = null!;
        public string? EstadoE { get; set; }
        public string? EstadoLe { get; set; }
        public DateTime? FechaCrm { get; set; }
        public int MesCrm { get; set; }
        public int TrimestreCrm { get; set; }
        public int AnoCrm { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public int MesA { get; set; }
        public int TrimestreAplicacion { get; set; }
        public int AnoA { get; set; }
        public string? Proveedor { get; set; }
        public short EmbarqueLinea { get; set; }
        public string NombreProveedor { get; set; } = null!;
        public string? OrdenCompra { get; set; }
        public string Articulo { get; set; } = null!;
        public string DescripcionArticulo { get; set; } = null!;
        public string EstadoArticulo { get; set; } = null!;
        public decimal? CantidadEmbarcada { get; set; }
        public decimal CantidadRecibida { get; set; }
        public decimal CantidadRechazada { get; set; }
        public decimal? CantidadFaltante { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal? PrecioUnitario { get; set; }
        public decimal? PrecioUnitarioLocal { get; set; }
        public decimal? PrecioUnitarioDolar { get; set; }
        public int? Cta { get; set; }
    }
}
