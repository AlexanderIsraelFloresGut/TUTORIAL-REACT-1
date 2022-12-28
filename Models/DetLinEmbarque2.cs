using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DetLinEmbarque2
    {
        public string Embarque { get; set; } = null!;
        public short EmbarqueLinea { get; set; }
        public short Secuencia { get; set; }
        public int? SerieCadena { get; set; }
        public string? Lote { get; set; }
        public string? Bodega { get; set; }
        public string? Localizacion { get; set; }
        public decimal CantRecibida { get; set; }
        public decimal CantRechazada { get; set; }
        public decimal? CantRecibidaUa { get; set; }
        public decimal? CantRechazadaUa { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual EmbarqueLinea2 EmbarqueNavigation { get; set; } = null!;
        public virtual Localizacion2? Localizacion2 { get; set; }
        public virtual SerieCadena2? SerieCadenaNavigation { get; set; }
    }
}
