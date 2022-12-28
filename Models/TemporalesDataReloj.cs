using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class TemporalesDataReloj
    {
        public int? IdEmpleado { get; set; }
        public string? Nombre { get; set; }
        public string? Departamento { get; set; }
        public string? Fecha { get; set; }
        public string? HoraEntrada { get; set; }
        public string? HoraSalida { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
