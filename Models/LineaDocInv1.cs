using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class LineaDocInv1
    {
        public string PaqueteInventario { get; set; } = null!;
        public string DocumentoInv { get; set; } = null!;
        public int LineaDocInv { get; set; }
        public string AjusteConfig { get; set; } = null!;
        public string? Nit { get; set; }
        public string Articulo { get; set; } = null!;
        public string? Bodega { get; set; }
        public string? Localizacion { get; set; }
        public string? Lote { get; set; }
        public string Tipo { get; set; } = null!;
        public string Subtipo { get; set; } = null!;
        public string Subsubtipo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public decimal CostoTotalLocal { get; set; }
        public decimal CostoTotalDolar { get; set; }
        public decimal PrecioTotalLocal { get; set; }
        public decimal PrecioTotalDolar { get; set; }
        public string? BodegaDestino { get; set; }
        public string? LocalizacionDest { get; set; }
        public string? CentroCosto { get; set; }
        public DateTime? Secuencia { get; set; }
        public int? SerieCadena { get; set; }
        public string? UnidadDistribucio { get; set; }
        public string? CuentaContable { get; set; }
        public decimal CostoTotalLocalComp { get; set; }
        public decimal CostoTotalDolarComp { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
        public string? Cai { get; set; }
        public string? TipoOperacion { get; set; }
        public string? TipoPago { get; set; }

        public virtual AjusteConfig1 AjusteConfigNavigation { get; set; } = null!;
        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual CentroCuentum1? C { get; set; }
        public virtual DocumentoInv1 DocumentoInv1 { get; set; } = null!;
        public virtual Localizacion1? Localizacion1 { get; set; }
        public virtual Localizacion1? Localizacion1Navigation { get; set; }
        public virtual Lote1? Lote1 { get; set; }
        public virtual Nit1? NitNavigation { get; set; }
        public virtual SerieCadena1? SerieCadenaNavigation { get; set; }
        public virtual TipoOperacion1? TipoOperacionNavigation { get; set; }
        public virtual TipoPago1? TipoPagoNavigation { get; set; }
        public virtual UnidadDeMedidum1? UnidadDistribucioNavigation { get; set; }
    }
}
