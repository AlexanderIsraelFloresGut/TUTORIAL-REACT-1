using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Responsable
    {
        public Responsable()
        {
            ActivoAccions = new HashSet<ActivoAccion>();
            ActivoMejoras = new HashSet<ActivoMejora>();
            CajaChicas = new HashSet<CajaChica>();
            SolicitudAfNotifResponsableCreadoporNavigations = new HashSet<SolicitudAfNotif>();
            SolicitudAfNotifResponsableCreadorNavigations = new HashSet<SolicitudAfNotif>();
            SolicitudAfNotifResponsableTrasladoNavigations = new HashSet<SolicitudAfNotif>();
        }

        public string Responsable1 { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Empleado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<ActivoAccion> ActivoAccions { get; set; }
        public virtual ICollection<ActivoMejora> ActivoMejoras { get; set; }
        public virtual ICollection<CajaChica> CajaChicas { get; set; }
        public virtual ICollection<SolicitudAfNotif> SolicitudAfNotifResponsableCreadoporNavigations { get; set; }
        public virtual ICollection<SolicitudAfNotif> SolicitudAfNotifResponsableCreadorNavigations { get; set; }
        public virtual ICollection<SolicitudAfNotif> SolicitudAfNotifResponsableTrasladoNavigations { get; set; }
    }
}
