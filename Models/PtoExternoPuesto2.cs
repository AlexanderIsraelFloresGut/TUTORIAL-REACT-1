using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PtoExternoPuesto2
    {
        public string Puesto { get; set; } = null!;
        public string CatPuestoExterno { get; set; } = null!;
        public string PuestoExterno { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual PuestoExterno2 PuestoExterno2 { get; set; } = null!;
        public virtual Puesto2 PuestoNavigation { get; set; } = null!;
    }
}
