using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PistaExistenDet1
    {
        public DateTime Fecha { get; set; }
        public string Bodega { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Localizacion { get; set; } = null!;
        public string Lote { get; set; } = null!;
        public decimal CantDisponible { get; set; }
        public decimal CantReservada { get; set; }
        public decimal CantNoAprobada { get; set; }
        public decimal CantVencida { get; set; }
        public decimal CantRemitida { get; set; }
        public decimal CostoFiscalLoc { get; set; }
        public decimal CostoFiscalDol { get; set; }
        public decimal CostoCompLoc { get; set; }
        public decimal CostoCompDol { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ExistenciaBodega1 ExistenciaBodega1 { get; set; } = null!;
        public virtual PistaExistencium1 FechaNavigation { get; set; } = null!;
        public virtual Localizacion1 Localizacion1 { get; set; } = null!;
        public virtual Lote1 Lote1 { get; set; } = null!;
    }
}
