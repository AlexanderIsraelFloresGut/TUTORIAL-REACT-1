using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DespachoDetalle2
    {
        public string Despacho { get; set; } = null!;
        public short Linea { get; set; }
        public string Articulo { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string? Lote { get; set; }
        public string? Localizacion { get; set; }
        public decimal CostoLocal { get; set; }
        public decimal CostoDolar { get; set; }
        public string DocumOrig { get; set; } = null!;
        public string TipoDocumOrig { get; set; } = null!;
        public short LineaDocumOrig { get; set; }
        public int? SerieCadena { get; set; }
        public string TipoLinea { get; set; } = null!;
        public short? LineaKit { get; set; }
        public int? ConsecTinvIni { get; set; }
        public int? ConsecTinvFin { get; set; }
        public decimal CostoLocalComp { get; set; }
        public decimal CostoDolarComp { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo2 ArticuloNavigation { get; set; } = null!;
        public virtual Bodega2 BodegaNavigation { get; set; } = null!;
        public virtual Despacho2 DespachoNavigation { get; set; } = null!;
        public virtual FacturaLinea2 FacturaLinea2 { get; set; } = null!;
        public virtual SerieCadena2? SerieCadenaNavigation { get; set; }
    }
}
