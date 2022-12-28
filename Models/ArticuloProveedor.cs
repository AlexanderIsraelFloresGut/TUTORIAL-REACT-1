using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArticuloProveedor
    {
        public string Articulo { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string? CodigoCatalogo { get; set; }
        public decimal LoteMinimo { get; set; }
        public decimal LoteEstandar { get; set; }
        public decimal PesoMinimoOrden { get; set; }
        public decimal MultiploCompra { get; set; }
        public decimal CantEconomicaCom { get; set; }
        public string UnidadMedidaComp { get; set; } = null!;
        public decimal FactorConversion { get; set; }
        public short PlazoReabastecimi { get; set; }
        public decimal PorcAjusteCosto { get; set; }
        public DateTime? FechaUltCotizaci { get; set; }
        public string? Notas { get; set; }
        public string? DescripCatalogo { get; set; }
        public string Pais { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? Impuesto { get; set; }

        public virtual Articulo ArticuloNavigation { get; set; } = null!;
        public virtual Proveedor ProveedorNavigation { get; set; } = null!;
    }
}
