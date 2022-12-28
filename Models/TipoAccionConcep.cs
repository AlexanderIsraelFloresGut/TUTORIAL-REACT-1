using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoAccionConcep
    {
        public string TipoAccion { get; set; } = null!;
        public short Secuencia { get; set; }
        public string Concepto { get; set; } = null!;
        public string? Nomina { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto ConceptoNavigation { get; set; } = null!;
        public virtual Nomina? NominaNavigation { get; set; }
        public virtual TipoAccion TipoAccionNavigation { get; set; } = null!;
    }
}
