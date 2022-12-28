using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SoftlandBiCoEmbarqueFactura
    {
        public string? Proveedor { get; set; }
        public string NombreProveedor { get; set; } = null!;
        public string Embarque { get; set; } = null!;
        public string? OrdenCompra { get; set; }
        public string Articulo { get; set; } = null!;
        public string NombreArticulo { get; set; } = null!;
        public string? TipoArticulo { get; set; }
        public string ClaseArticulo { get; set; } = null!;
        public string EstadoArticulo { get; set; } = null!;
        public string? Clasificacion1 { get; set; }
        public string? Clasificacion2 { get; set; }
        public string? Clasificacion3 { get; set; }
        public string? Clasificacion4 { get; set; }
        public string? Clasificacion5 { get; set; }
        public string? Clasificacion6 { get; set; }
        public decimal CantidadRecibida { get; set; }
        public string Moneda { get; set; } = null!;
        public decimal? PrecioUnitario { get; set; }
        public decimal? TipoCambio { get; set; }
        public decimal? PrecioUnitarioLocal { get; set; }
        public decimal? PrecioUnitarioDolar { get; set; }
        public decimal CostoUnitarioFiscalLocal { get; set; }
        public decimal CostoUnitarioFiscalDolar { get; set; }
        public decimal CostoUnitarioRealLocal { get; set; }
        public decimal CostoUnitarioRealDolar { get; set; }
        public string? EstadoEmbarque { get; set; }
        public string? EstadoLiquidacionEmbarque { get; set; }
        public string? DocumentoEmbarque { get; set; }
        public string? TipoDocumentoEmbarque { get; set; }
        public string? FacturaEnCp { get; set; }
        public decimal? SubtotalLineaLocal { get; set; }
        public decimal? SubtotalLineaDolar { get; set; }
        public decimal? TotalDescuentoLocal { get; set; }
        public decimal? TotalDescuentoDolar { get; set; }
        public int AnoFactura { get; set; }
        public int TrimestreFactura { get; set; }
        public int MesFactura { get; set; }
        public DateTime? FechaFactura { get; set; }
    }
}
