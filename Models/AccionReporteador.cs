using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class AccionReporteador
    {
        public AccionReporteador()
        {
            PrivilegioReporteadors = new HashSet<PrivilegioReporteador>();
        }

        public int Accion { get; set; }
        public int? Entidad { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual DdEntidad? EntidadNavigation { get; set; }
        public virtual ICollection<PrivilegioReporteador> PrivilegioReporteadors { get; set; }
    }
}
