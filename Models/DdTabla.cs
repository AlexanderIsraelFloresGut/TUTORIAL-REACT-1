using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class DdTabla
    {
        public DdTabla()
        {
            DdEntidadTablas = new HashSet<DdEntidadTabla>();
            DdModuloTablas = new HashSet<DdModuloTabla>();
            DdPropietarioTablas = new HashSet<DdPropietarioTabla>();
            ReporteParametros = new HashSet<ReporteParametro>();
        }

        public string Tabla { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string Nombre { get; set; } = null!;
        public string Alias { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ICollection<DdEntidadTabla> DdEntidadTablas { get; set; }
        public virtual ICollection<DdModuloTabla> DdModuloTablas { get; set; }
        public virtual ICollection<DdPropietarioTabla> DdPropietarioTablas { get; set; }
        public virtual ICollection<ReporteParametro> ReporteParametros { get; set; }
    }
}
