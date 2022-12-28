using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoHoraExtraRecar2
    {
        public TipoHoraExtraRecar2()
        {
            Concepto2s = new HashSet<Concepto2>();
        }

        public string TipoHoraExtra { get; set; } = null!;
        public string? Nombre { get; set; }
        public decimal Porcentaje { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<Concepto2> Concepto2s { get; set; }
    }
}
