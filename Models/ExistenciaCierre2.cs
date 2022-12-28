using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExistenciaCierre2
    {
        public DateTime FechaCierre { get; set; }
        public string Articulo { get; set; } = null!;
        public string TipoCosto { get; set; } = null!;
        public string TipoFecha { get; set; } = null!;
        public string Bodega { get; set; } = null!;
        public decimal CostoFiscUntLoc { get; set; }
        public decimal CostoFiscUntDol { get; set; }
        public decimal CostoCompUntLoc { get; set; }
        public decimal CostoCompUntDol { get; set; }
        public decimal CantDisponible { get; set; }
        public decimal CantReservada { get; set; }
        public decimal CantNoAprobada { get; set; }
        public decimal CantVencida { get; set; }
        public decimal CantRemitida { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo2 ArticuloNavigation { get; set; } = null!;
        public virtual Bodega2 BodegaNavigation { get; set; } = null!;
    }
}
