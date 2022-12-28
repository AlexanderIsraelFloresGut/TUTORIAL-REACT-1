using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ExistenciaLote2
    {
        public string Bodega { get; set; } = null!;
        public string Articulo { get; set; } = null!;
        public string Localizacion { get; set; } = null!;
        public string Lote { get; set; } = null!;
        public decimal CantDisponible { get; set; }
        public decimal CantReservada { get; set; }
        public decimal CantNoAprobada { get; set; }
        public decimal CantVencida { get; set; }
        public decimal CantRemitida { get; set; }
        public decimal CostoUntPromedioLoc { get; set; }
        public decimal CostoUntPromedioDol { get; set; }
        public decimal CostoUntEstandarLoc { get; set; }
        public decimal CostoUntEstandarDol { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ExistenciaBodega2 ExistenciaBodega2 { get; set; } = null!;
        public virtual Localizacion2 Localizacion2 { get; set; } = null!;
        public virtual Lote2 Lote2 { get; set; } = null!;
    }
}
