using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class EmpleadoAcademico1
    {
        public string Empleado { get; set; } = null!;
        public DateTime FechaObtencion { get; set; }
        public string Titulo { get; set; } = null!;
        public string Institucion { get; set; } = null!;
        public DateTime? FechaVencimiento { get; set; }
        public short? HorasCurso { get; set; }
        public short? HorasCompletas { get; set; }
        public string Concluido { get; set; } = null!;
        public string? Profesor { get; set; }
        public string? Notas { get; set; }
        public string? TipoCapacitacion { get; set; }
        public short Consecutivo { get; set; }
        public string TipoAcademico { get; set; } = null!;
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }

        public virtual Empleado1 EmpleadoNavigation { get; set; } = null!;
        public virtual TipoAcademico1 TipoAcademicoNavigation { get; set; } = null!;
    }
}
