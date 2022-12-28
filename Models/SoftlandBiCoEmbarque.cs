using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCoEmbarque
    {
        public string Embarque { get; set; } = null!;
        public string? EstadoEmbarque { get; set; }
        public string? EstadoLiquidacionEmbarque { get; set; }
        public DateTime? FechaCrm { get; set; }
        public int MesCrm { get; set; }
        public int TrimestreCrm { get; set; }
        public int AnoCrm { get; set; }
        public DateTime? FechaAplicacion { get; set; }
        public int MesAplicacion { get; set; }
        public int TrimestreAplicacion { get; set; }
        public int AnoAplicacion { get; set; }
        public string PaisProcedencia { get; set; } = null!;
        public string NombrePaisProcedencia { get; set; } = null!;
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
    }
}
