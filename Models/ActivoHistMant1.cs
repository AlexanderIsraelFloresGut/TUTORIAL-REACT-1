using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ActivoHistMant1
    {
        public DateTime Fecha { get; set; }
        public string ActivoFijo { get; set; } = null!;
        public string TipoMantenimiento { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal Monto { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ActivoFijo1 ActivoFijoNavigation { get; set; } = null!;
    }
}
