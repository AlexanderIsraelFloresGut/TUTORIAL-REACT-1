using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OpOperParo
    {
        public string OrdenProduccion { get; set; } = null!;
        public string Operacion { get; set; } = null!;
        public DateTime FechaHoraProduc { get; set; }
        public short ParoLinea { get; set; }
        public string MotivoParo { get; set; } = null!;
        public decimal Duracion { get; set; }
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual MotivoParo MotivoParoNavigation { get; set; } = null!;
        public virtual OpOperDet OpOperDet { get; set; } = null!;
    }
}
