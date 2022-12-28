using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReportesContable2
    {
        public ReportesContable2()
        {
            SeccionReporte2s = new HashSet<SeccionReporte2>();
        }

        public string TipoR { get; set; } = null!;
        public string CodigoR { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Reporte { get; set; }
        public string? ReporteAmbas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<SeccionReporte2> SeccionReporte2s { get; set; }
    }
}
