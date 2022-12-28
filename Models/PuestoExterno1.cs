using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class PuestoExterno1
    {
        public PuestoExterno1()
        {
            PtoExternoPuesto1s = new HashSet<PtoExternoPuesto1>();
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

        public virtual CatPuestoExterno1 CatPuestoExternoNavigation { get; set; } = null!;
        public virtual ICollection<PtoExternoPuesto1> PtoExternoPuesto1s { get; set; }
    }
}
