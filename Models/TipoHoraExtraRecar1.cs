using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoHoraExtraRecar1
    {
        public TipoHoraExtraRecar1()
        {
            Concepto1s = new HashSet<Concepto1>();
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

        public virtual ICollection<Concepto1> Concepto1s { get; set; }
    }
}
