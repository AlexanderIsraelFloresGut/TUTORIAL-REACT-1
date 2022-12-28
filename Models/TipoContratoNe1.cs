using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoContratoNe1
    {
        public TipoContratoNe1()
        {
            TipoContrato1s = new HashSet<TipoContrato1>();
        }

        public string TipoContratoNe { get; set; } = null!;
        public string? Nombre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<TipoContrato1> TipoContrato1s { get; set; }
    }
}
