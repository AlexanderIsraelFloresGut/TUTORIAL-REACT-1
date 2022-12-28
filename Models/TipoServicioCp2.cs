using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoServicioCp2
    {
        public string TipoServicio { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? CentroCosto { get; set; }
        public string? CuentaContable { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CentroCuentum2? C { get; set; }
    }
}
