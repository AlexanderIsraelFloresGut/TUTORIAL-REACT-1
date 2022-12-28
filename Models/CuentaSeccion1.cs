using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class CuentaSeccion1
    {
        public string CuentaContable { get; set; } = null!;
        public string TipoR { get; set; } = null!;
        public string CodigoR { get; set; } = null!;
        public string SeccionR { get; set; } = null!;
        public string Subseccion { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual CuentaContable1 CuentaContableNavigation { get; set; } = null!;
        public virtual SubseccionReporte1 SubseccionReporte1 { get; set; } = null!;
    }
}
