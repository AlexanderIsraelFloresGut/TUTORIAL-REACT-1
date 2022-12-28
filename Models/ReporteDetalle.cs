using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class ReporteDetalle
    {
        public ReporteDetalle()
        {
            ReporteUsuarios = new HashSet<ReporteUsuario>();
        }

        public string Accion { get; set; } = null!;
        public string Reporte { get; set; } = null!;
        public string? Descripcion { get; set; }
        public string? Notas { get; set; }
        public string? Activo { get; set; }
        public string? Seguridad { get; set; }
        public string? Crc { get; set; }
        public byte[] Archivo { get; set; } = null!;
        public byte[]? Archivodtd { get; set; }
        public string? Dtd { get; set; }
        public string? Formato { get; set; }
        public string? Personalizacion { get; set; }
        public string? Fuentedatos { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual ReportePersonaliz AccionNavigation { get; set; } = null!;
        public virtual ICollection<ReporteUsuario> ReporteUsuarios { get; set; }
    }
}
