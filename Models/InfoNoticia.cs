using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class InfoNoticia
    {
        public Guid Identificador { get; set; }
        public int? Tipo { get; set; }
        public string? Titulo { get; set; }
        public string? Descripcion { get; set; }
        public int? Prioridad { get; set; }
        public int? Periodicidad { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public string? Modulos { get; set; }
        public string? VistoPor { get; set; }
        public int? PeriodoVisto { get; set; }
        public string? Vinculo { get; set; }
        public string? Estado { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
