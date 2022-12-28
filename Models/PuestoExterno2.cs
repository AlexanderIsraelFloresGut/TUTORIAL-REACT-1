using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PuestoExterno2
    {
        public PuestoExterno2()
        {
            PtoExternoPuesto2s = new HashSet<PtoExternoPuesto2>();
        }

        public string CatPuestoExterno { get; set; } = null!;
        public string PuestoExterno { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CatPuestoExterno2 CatPuestoExternoNavigation { get; set; } = null!;
        public virtual ICollection<PtoExternoPuesto2> PtoExternoPuesto2s { get; set; }
    }
}
