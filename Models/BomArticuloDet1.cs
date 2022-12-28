using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class BomArticuloDet1
    {
        public string Usuario { get; set; } = null!;
        public int Linea { get; set; }
        public string Componente { get; set; } = null!;
        public decimal CantRequerida { get; set; }
        public decimal? CantReservada { get; set; }
        public decimal? CantConsumida { get; set; }
        public decimal? CostoReqL { get; set; }
        public decimal? CostoReqD { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ComponenteNavigation { get; set; } = null!;
    }
}
