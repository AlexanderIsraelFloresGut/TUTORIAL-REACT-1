using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TipoSoliRhNotif2
    {
        public string TipoSolicitudRh { get; set; } = null!;
        public string Empleado { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado2 EmpleadoNavigation { get; set; } = null!;
        public virtual TipoSolicitudRh2 TipoSolicitudRhNavigation { get; set; } = null!;
    }
}
