using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CalendarioAno1
    {
        public string Calendario { get; set; } = null!;
        public short Mes { get; set; }
        public short Dia { get; set; }
        public short Minutos { get; set; }
        public string? Descripcion { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
        public string DiaHabil { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Calendario1 CalendarioNavigation { get; set; } = null!;
    }
}
