using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SeccionReporte
    {
        public SeccionReporte()
        {
            SubseccionReportes = new HashSet<SubseccionReporte>();
        }

        public string TipoR { get; set; } = null!;
        public string CodigoR { get; set; } = null!;
        public string SeccionR { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Acumulado { get; set; }
        public short Secuencia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ReportesContable ReportesContable { get; set; } = null!;
        public virtual ICollection<SubseccionReporte> SubseccionReportes { get; set; }
    }
}
