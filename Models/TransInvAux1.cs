using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TransInvAux1
    {
        public TransInvAux1()
        {
            OpConsumoProducc1s = new HashSet<OpConsumoProducc1>();
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

        public virtual TransaccionInv1 TransaccionInv1 { get; set; } = null!;
        public virtual ICollection<OpConsumoProducc1> OpConsumoProducc1s { get; set; }
    }
}
