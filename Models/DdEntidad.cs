using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdEntidad
    {
        public DdEntidad()
        {
            AccionReporteadors = new HashSet<AccionReporteador>();
            DdEntidadTablas = new HashSet<DdEntidadTabla>();
            InverseEntidadPadreNavigation = new HashSet<DdEntidad>();
            ReporteDefinicions = new HashSet<ReporteDefinicion>();
        }

        public int Entidad { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public int? EntidadPadre { get; set; }
        public string? Alias { get; set; }
        public string? Tipo { get; set; }
        public string Modulo { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DdEntidad? EntidadPadreNavigation { get; set; }
        public virtual ICollection<AccionReporteador> AccionReporteadors { get; set; }
        public virtual ICollection<DdEntidadTabla> DdEntidadTablas { get; set; }
        public virtual ICollection<DdEntidad> InverseEntidadPadreNavigation { get; set; }
        public virtual ICollection<ReporteDefinicion> ReporteDefinicions { get; set; }
    }
}
