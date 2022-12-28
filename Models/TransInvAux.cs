using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TransInvAux
    {
        public TransInvAux()
        {
            OpConsumoProduccs = new HashSet<OpConsumoProducc>();
        }

        public int AuditTransInv { get; set; }
        public int Consecutivo { get; set; }
        public string? Orden { get; set; }
        public string? Operacion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual TransaccionInv TransaccionInv { get; set; } = null!;
        public virtual ICollection<OpConsumoProducc> OpConsumoProduccs { get; set; }
    }
}
