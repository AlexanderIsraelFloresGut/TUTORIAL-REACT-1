using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoContratoNe
    {
        public TipoContratoNe()
        {
            TipoContratos = new HashSet<TipoContrato>();
        }

        public string TipoContratoNe1 { get; set; } = null!;
        public string? Nombre { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<TipoContrato> TipoContratos { get; set; }
    }
}
