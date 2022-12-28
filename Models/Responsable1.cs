using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class Responsable1
    {
        public Responsable1()
        {
            ActivoAccion1s = new HashSet<ActivoAccion1>();
            ActivoMejora1s = new HashSet<ActivoMejora1>();
            CajaChica1s = new HashSet<CajaChica1>();
            SolicitudAfNotif1ResponsableCreadoporNavigations = new HashSet<SolicitudAfNotif1>();
            SolicitudAfNotif1ResponsableCreadorNavigations = new HashSet<SolicitudAfNotif1>();
            SolicitudAfNotif1ResponsableTrasladoNavigations = new HashSet<SolicitudAfNotif1>();
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
        public string? Contribuyente { get; set; }

        public virtual Nit1? ContribuyenteNavigation { get; set; }
        public virtual Empleado1? EmpleadoNavigation { get; set; }
        public virtual ICollection<ActivoAccion1> ActivoAccion1s { get; set; }
        public virtual ICollection<ActivoMejora1> ActivoMejora1s { get; set; }
        public virtual ICollection<CajaChica1> CajaChica1s { get; set; }
        public virtual ICollection<SolicitudAfNotif1> SolicitudAfNotif1ResponsableCreadoporNavigations { get; set; }
        public virtual ICollection<SolicitudAfNotif1> SolicitudAfNotif1ResponsableCreadorNavigations { get; set; }
        public virtual ICollection<SolicitudAfNotif1> SolicitudAfNotif1ResponsableTrasladoNavigations { get; set; }
    }
}
