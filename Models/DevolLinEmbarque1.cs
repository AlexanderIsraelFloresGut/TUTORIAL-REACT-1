using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DevolLinEmbarque1
    {
        public string Devolucion { get; set; } = null!;
        public short DevolucionLinea { get; set; }
        public int? SerieCadena { get; set; }
        public string? OrdenCompra { get; set; }
        public string Bodega { get; set; } = null!;
        public string? Localizacion { get; set; }
        public string? Lote { get; set; }
        public string Embarque { get; set; } = null!;
        public short EmbarqueLinea { get; set; }
        public decimal CantDevuelta { get; set; }
        public decimal CantDevueltaua { get; set; }
        public decimal? MontoDebito { get; set; }
        public decimal? MontoUnLocal { get; set; }
        public decimal? MontoUnDolar { get; set; }
        public short? OrdenCompraLinea { get; set; }
        public decimal? Importe { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Impuesto1 { get; set; }
        public decimal? Impuesto2 { get; set; }
        public decimal? Rubro1 { get; set; }
        public decimal? Rubro2 { get; set; }
        public string Imp1Afectacosto { get; set; } = null!;
        public string Imp2Afectacosto { get; set; } = null!;
        public string Rubro1Afectacosto { get; set; } = null!;
        public string Rubro2Afectacosto { get; set; } = null!;
        public decimal? DescuentoLinea { get; set; }
        public decimal? BaseImpuesto1 { get; set; }
        public decimal? BaseImpuesto2 { get; set; }
        public decimal? Imp1AsumidoDesc { get; set; }
        public decimal? Imp1AsumidoNodesc { get; set; }
        public decimal? Imp1RetenidoDesc { get; set; }
        public decimal? Imp1RetenidoNodesc { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public decimal? MontoTotalImpuestoAcreditar { get; set; }
        public decimal? MontoTotalDeGastoAplicable { get; set; }
        public decimal? MontoProporcionalidad { get; set; }
        public decimal? SubtotalBienes { get; set; }
        public decimal? SubtotalServicios { get; set; }

        public virtual Devolucion1 DevolucionNavigation { get; set; } = null!;
        public virtual EmbarqueLinea1 EmbarqueNavigation { get; set; } = null!;
        public virtual Localizacion1? Localizacion1 { get; set; }
        public virtual OrdenCompraLinea1? OrdenCompraNavigation { get; set; }
        public virtual SerieCadena1? SerieCadenaNavigation { get; set; }
    }
}
