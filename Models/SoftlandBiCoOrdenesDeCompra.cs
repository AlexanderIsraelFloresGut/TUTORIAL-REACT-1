using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCoOrdenesDeCompra
    {
        public string OrdenCompra { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string NombreProveedor { get; set; } = null!;
        public string? EstadoOrdenCompra { get; set; }
        public string Moneda { get; set; } = null!;
        public string PaisOrdenCompra { get; set; } = null!;
        public DateTime FechaOrdenCompra { get; set; }
        public int? AnoFechaOrdenCompra { get; set; }
        public int? TrimestreFechaOrdenCompra { get; set; }
        public int? MesFechaOrdenCompra { get; set; }
        public int? SemanaFechaOrdenCompra { get; set; }
        public DateTime FechaRequeridaOrdenCompra { get; set; }
        public int? AnoRequeridaOrdenCompra { get; set; }
        public int? TrimestreRequeridaOrdenCompra { get; set; }
        public int? MesRequeridaOrdenCompra { get; set; }
        public int? SemanaRequeridaOrdenCompra { get; set; }
        public decimal? TipoCambio { get; set; }
        public string? EstadoLinea { get; set; }
        public string Bodega { get; set; } = null!;
        public string NombreBodega { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string EstadoArticulo { get; set; } = null!;
        public decimal PrecioUnitario { get; set; }
        public decimal? PrecioUnitarioLocal { get; set; }
        public decimal? PrecioUnitarioDolar { get; set; }
        public decimal CantidadOrdenada { get; set; }
        public decimal CantidadEmbarcada { get; set; }
        public decimal CantidadRecibida { get; set; }
        public decimal CantidadRechazada { get; set; }
    }
}
