using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperRef2
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime FechaHoraProduc { get; set; }
        public int Consecutivo { get; set; }
        public Guid ReferenciaBackflush { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OpOperDet2 OpOperDet2 { get; set; } = null!;
    }
}
