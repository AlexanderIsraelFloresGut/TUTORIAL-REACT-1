using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AdminConcepto
    {
        public string Administradora { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Administradora AdministradoraNavigation { get; set; } = null!;
        public virtual Concepto ConceptoNavigation { get; set; } = null!;
    }
}
