using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ArticuloCompra2
    {
        public string Articulo { get; set; } = null!;
        public string? UltProveedor { get; set; }
        public string? UltMoneda { get; set; }
        public string Impuesto { get; set; } = null!;
        public string? CodigoArancel { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? CodigoCorporativo { get; set; }
        public string Imp1AfectaCosto { get; set; } = null!;
        public decimal? PorcVariacCant { get; set; }
        public decimal? UltPrecUnitario { get; set; }
        public DateTime? UltFechaCotiza { get; set; }
        public string RecibirMas { get; set; } = null!;
        public string? Bodega { get; set; }
        public string UsaCtaTransito { get; set; } = null!;
        public string? AceptaBackorderMonto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? TipoCompra { get; set; }

        public virtual Articulo2 ArticuloNavigation { get; set; } = null!;
        public virtual Bodega2? BodegaNavigation { get; set; }
        public virtual CodigoArancel2? CodigoArancelNavigation { get; set; }
        public virtual Impuesto2 ImpuestoNavigation { get; set; } = null!;
        public virtual Monedum2? UltMonedaNavigation { get; set; }
        public virtual Proveedor2? UltProveedorNavigation { get; set; }
    }
}
