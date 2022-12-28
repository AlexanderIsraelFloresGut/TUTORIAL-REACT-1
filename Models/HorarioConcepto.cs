using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class HorarioConcepto
    {
        public string Horario { get; set; } = null!;
        public short Dia { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
        public string? Concepto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Concepto? ConceptoNavigation { get; set; }
        public virtual Horario HorarioNavigation { get; set; } = null!;
    }
}
