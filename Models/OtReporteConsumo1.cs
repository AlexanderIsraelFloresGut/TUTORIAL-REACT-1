using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class OtReporteConsumo1
    {
        public int OrdenTrabajo { get; set; }
        public string Referencia { get; set; } = null!;
        public short Consecutivo { get; set; }
        public string Articulo { get; set; } = null!;
        public decimal Cantidad { get; set; }
        public string Equipo { get; set; } = null!;
        public string? Comentario { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Articulo1 ArticuloNavigation { get; set; } = null!;
        public virtual Equipo1 EquipoNavigation { get; set; } = null!;
        public virtual ReporteLabor1 ReporteLabor1 { get; set; } = null!;
    }
}
