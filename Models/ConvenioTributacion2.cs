using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ConvenioTributacion2
    {
        public ConvenioTributacion2()
        {
            Proveedor2s = new HashSet<Proveedor2>();
        }

        public string Convenio { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Proveedor2> Proveedor2s { get; set; }
    }
}
