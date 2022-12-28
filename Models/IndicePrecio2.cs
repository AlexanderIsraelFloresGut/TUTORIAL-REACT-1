using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class IndicePrecio2
    {
        public string TipoIndicePrecio { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual TipoIndicePrecio2 TipoIndicePrecioNavigation { get; set; } = null!;
    }
}
