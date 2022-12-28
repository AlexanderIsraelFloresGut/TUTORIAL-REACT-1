using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AuditTransMant
    {
        public AuditTransMant()
        {
            TransaccionMants = new HashSet<TransaccionMant>();
        }

        public DateTime AuditTransMant1 { get; set; }
        public string Aplicacion { get; set; } = null!;
        public string Referencia { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<TransaccionMant> TransaccionMants { get; set; }
    }
}
