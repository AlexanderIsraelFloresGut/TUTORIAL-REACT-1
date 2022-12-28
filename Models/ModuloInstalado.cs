using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ModuloInstalado
    {
        public string Conjunto { get; set; } = null!;
        public int Accion { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Accion AccionNavigation { get; set; } = null!;
        public virtual Conjunto ConjuntoNavigation { get; set; } = null!;
    }
}
