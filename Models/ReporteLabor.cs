using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReporteLabor
    {
        public ReporteLabor()
        {
            OtReporteConsumos = new HashSet<OtReporteConsumo>();
            OtReporteLabors = new HashSet<OtReporteLabor>();
        }

        public int OrdenTrabajo { get; set; }
        public string Referencia { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? Comentario { get; set; }
        public string Aprobado { get; set; } = null!;
        public string Contabilizado { get; set; } = null!;
        public string? Asiento { get; set; }
        public string Usuario { get; set; } = null!;
        public DateTime FechaHora { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual OrdenTrabajo OrdenTrabajoNavigation { get; set; } = null!;
        public virtual Usuario2 UsuarioNavigation { get; set; } = null!;
        public virtual ICollection<OtReporteConsumo> OtReporteConsumos { get; set; }
        public virtual ICollection<OtReporteLabor> OtReporteLabors { get; set; }
    }
}
