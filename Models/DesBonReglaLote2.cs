using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DesBonReglaLote2
    {
        public string Regla { get; set; } = null!;
        public int LineaRegla { get; set; }
        public int? DiasDesde { get; set; }
        public int? DiasHasta { get; set; }
        public int? CantMeses { get; set; }
        public decimal? Descuento { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DesBonRegla2 ReglaNavigation { get; set; } = null!;
    }
}
