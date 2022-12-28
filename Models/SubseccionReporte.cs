using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SubseccionReporte
    {
        public SubseccionReporte()
        {
            CuentaSeccions = new HashSet<CuentaSeccion>();
        }

        public string TipoR { get; set; } = null!;
        public string CodigoR { get; set; } = null!;
        public string SeccionR { get; set; } = null!;
        public string Subseccion { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public string? Acumulado { get; set; }
        public short Secuencia { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual SeccionReporte SeccionReporte { get; set; } = null!;
        public virtual ICollection<CuentaSeccion> CuentaSeccions { get; set; }
    }
}
