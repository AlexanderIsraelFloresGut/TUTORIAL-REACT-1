using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoContratoNe2
    {
        public TipoContratoNe2()
        {
            TipoContrato2s = new HashSet<TipoContrato2>();
        }

        public string TipoContratoNe { get; set; } = null!;
        public string? Nombre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<TipoContrato2> TipoContrato2s { get; set; }
    }
}
