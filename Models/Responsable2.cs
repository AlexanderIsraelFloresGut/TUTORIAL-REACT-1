using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Responsable2
    {
        public Responsable2()
        {
            ActivoAccion2s = new HashSet<ActivoAccion2>();
            ActivoMejora2s = new HashSet<ActivoMejora2>();
            CajaChica2s = new HashSet<CajaChica2>();
            SolicitudAfNotif2ResponsableCreadoporNavigations = new HashSet<SolicitudAfNotif2>();
            SolicitudAfNotif2ResponsableCreadorNavigations = new HashSet<SolicitudAfNotif2>();
            SolicitudAfNotif2ResponsableTrasladoNavigations = new HashSet<SolicitudAfNotif2>();
        }

        public string Responsable { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string? Empleado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado2? EmpleadoNavigation { get; set; }
        public virtual ICollection<ActivoAccion2> ActivoAccion2s { get; set; }
        public virtual ICollection<ActivoMejora2> ActivoMejora2s { get; set; }
        public virtual ICollection<CajaChica2> CajaChica2s { get; set; }
        public virtual ICollection<SolicitudAfNotif2> SolicitudAfNotif2ResponsableCreadoporNavigations { get; set; }
        public virtual ICollection<SolicitudAfNotif2> SolicitudAfNotif2ResponsableCreadorNavigations { get; set; }
        public virtual ICollection<SolicitudAfNotif2> SolicitudAfNotif2ResponsableTrasladoNavigations { get; set; }
    }
}
