using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PuestoExterno
    {
        public PuestoExterno()
        {
            PtoExternoPuestos = new HashSet<PtoExternoPuesto>();
        }

        public string CatPuestoExterno { get; set; } = null!;
        public string PuestoExterno1 { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CatPuestoExterno CatPuestoExternoNavigation { get; set; } = null!;
        public virtual ICollection<PtoExternoPuesto> PtoExternoPuestos { get; set; }
    }
}
