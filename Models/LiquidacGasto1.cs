using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LiquidacGasto1
    {
        public string LiquidacCompra { get; set; } = null!;
        public short LineaGasto { get; set; }
        public string? Nit { get; set; }
        public string? Articulo { get; set; }
        public string Moneda { get; set; } = null!;
        public string? Embarque { get; set; }
        public string? GastoCompra { get; set; }
        public short? Secuencia { get; set; }
        public DateTime? FechaGasto { get; set; }
        public string Descripcion { get; set; } = null!;
        public string? TipoProrrateo { get; set; }
        public decimal MontoGasto { get; set; }
        public decimal TipoCambioLocal { get; set; }
        public decimal TipoCambioDolar { get; set; }
        public string Destino { get; set; } = null!;
        public string? Etiqueta { get; set; }
        public short? LineaEmbarque { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public string? Factura { get; set; }
        public string? ProveedorFactura { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1? ArticuloNavigation { get; set; }
        public virtual Embarque1? EmbarqueNavigation { get; set; }
        public virtual GastoCompra1? GastoCompraNavigation { get; set; }
        public virtual LiquidacCompra1 LiquidacCompraNavigation { get; set; } = null!;
        public virtual Monedum1 MonedaNavigation { get; set; } = null!;
        public virtual Nit1? NitNavigation { get; set; }
    }
}
