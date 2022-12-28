using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoPariente1
    {
        public string Empleado { get; set; } = null!;
        public short Consecutivo { get; set; }
        public string Nombre { get; set; } = null!;
        public DateTime? FechaNacimiento { get; set; }
        public string Parentesco { get; set; } = null!;
        public string? LugarTrabajo { get; set; }
        public string? Puesto { get; set; }
        public string? NivelAcademico { get; set; }
        public string? LugarEstudio { get; set; }
        public string? Telefono { get; set; }
        public string? Notas { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
    }
}
