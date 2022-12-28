using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdEntidadTabla
    {
        public DdEntidadTabla()
        {
            DdColumnaCases = new HashSet<DdColumnaCase>();
            DdRelacionEntidadDdEntidadTablaNavigations = new HashSet<DdRelacionEntidad>();
            DdRelacionEntidadDdEntidadTablas = new HashSet<DdRelacionEntidad>();
            DdRelacionEntidadTablaDdEntidadTablaNavigations = new HashSet<DdRelacionEntidadTabla>();
            DdRelacionEntidadTablaDdEntidadTablas = new HashSet<DdRelacionEntidadTabla>();
        }

        public int Entidad { get; set; }
        public string Alias { get; set; } = null!;
        public string Tabla { get; set; } = null!;
        public string Propietario { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DdEntidad EntidadNavigation { get; set; } = null!;
        public virtual DdTabla TablaNavigation { get; set; } = null!;
        public virtual ICollection<DdColumnaCase> DdColumnaCases { get; set; }
        public virtual ICollection<DdRelacionEntidad> DdRelacionEntidadDdEntidadTablaNavigations { get; set; }
        public virtual ICollection<DdRelacionEntidad> DdRelacionEntidadDdEntidadTablas { get; set; }
        public virtual ICollection<DdRelacionEntidadTabla> DdRelacionEntidadTablaDdEntidadTablaNavigations { get; set; }
        public virtual ICollection<DdRelacionEntidadTabla> DdRelacionEntidadTablaDdEntidadTablas { get; set; }
    }
}
