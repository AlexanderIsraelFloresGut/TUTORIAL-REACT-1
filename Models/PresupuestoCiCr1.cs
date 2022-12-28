using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PresupuestoCiCr1
    {
        public int? AuditTransInv { get; set; }
        public string? PaqueteInventario { get; set; }
        public string DocumentoInv { get; set; } = null!;
        public string Presupuesto { get; set; } = null!;
        public int? Apartado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual AuditTransInv1? AuditTransInvNavigation { get; set; }
        public virtual PaqueteInventario1? PaqueteInventarioNavigation { get; set; }
    }
}
