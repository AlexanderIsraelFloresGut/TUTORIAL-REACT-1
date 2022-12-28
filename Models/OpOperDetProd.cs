using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperDetProd
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime FechaHoraProduc { get; set; }
        public short DetProdLinea { get; set; }
        public string? Cliente { get; set; }
        public string? Articulo { get; set; }
        public string Lote { get; set; } = null!;
        public DateTime? FechaVencimiento { get; set; }
        public string Bodega { get; set; } = null!;
        public string Localizacion { get; set; } = null!;
        public string Estado { get; set; } = null!;
        public string Calidad { get; set; } = null!;
        public decimal CantidadProducida { get; set; }
        public decimal CantidadRechazada { get; set; }
        public decimal CostoUnitInvLoc { get; set; }
        public decimal CostoUnitInvDol { get; set; }
        public int? AuditTransInv { get; set; }
        public string Inventariable { get; set; } = null!;
        public string? Contabilizada { get; set; }
        public string? Liquidacion { get; set; }
        public int? SerieCadena { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo? ArticuloNavigation { get; set; }
        public virtual Bodega BodegaNavigation { get; set; } = null!;
        public virtual Cliente? ClienteNavigation { get; set; }
        public virtual OpOperDet OpOperDet { get; set; } = null!;
        public virtual SerieCadena? SerieCadenaNavigation { get; set; }
    }
}
