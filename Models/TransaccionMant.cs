using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TransaccionMant
    {
        public DateTime AuditTransMant { get; set; }
        public short Consecutivo { get; set; }
        public string TipoTransaccion { get; set; } = null!;
        public string Equipo { get; set; } = null!;
        public short Nivel { get; set; }
        public decimal CostoLocal { get; set; }
        public decimal CostoDolar { get; set; }
        public DateTime Fecha { get; set; }
        public string TieneHijos { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AuditTransMant AuditTransMantNavigation { get; set; } = null!;
        public virtual Equipo EquipoNavigation { get; set; } = null!;
    }
}
