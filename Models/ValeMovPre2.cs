using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ValeMovPre2
    {
        public int Vale { get; set; }
        public string Presupuesto { get; set; } = null!;
        public string? UnidadOperativa { get; set; }
        public int? NumeroEjercido { get; set; }
        public int? NumeroApartado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Vale2 ValeNavigation { get; set; } = null!;
    }
}
