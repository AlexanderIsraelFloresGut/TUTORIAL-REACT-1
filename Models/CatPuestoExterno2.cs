using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CatPuestoExterno2
    {
        public CatPuestoExterno2()
        {
            PuestoExterno2s = new HashSet<PuestoExterno2>();
        }

        public string CatPuestoExterno { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<PuestoExterno2> PuestoExterno2s { get; set; }
    }
}
