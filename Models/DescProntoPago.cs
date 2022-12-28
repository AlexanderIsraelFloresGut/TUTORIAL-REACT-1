using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DescProntoPago
    {
        public string CondicionPago { get; set; } = null!;
        public short Consecutivo { get; set; }
        public int DiaInicio { get; set; }
        public int DiaFin { get; set; }
        public decimal Descuento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CondicionPago CondicionPagoNavigation { get; set; } = null!;
    }
}
