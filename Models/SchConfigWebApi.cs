using System;
using System.Collections.Generic;

namespace TUTORIAL_REACT_1.Models
{
    public partial class SchConfigWebApi
    {
        public string Compania { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string DireccionWeb { get; set; } = null!;
        public string Usuario { get; set; } = null!;
        public string Clave { get; set; } = null!;
        public string Acciondepartamento { get; set; } = null!;
        public string Accionpuesto { get; set; } = null!;
        public string? Accionbaja { get; set; }
        public string Accionsalario { get; set; } = null!;
        public string Accionvacasgoce { get; set; } = null!;
        public string Accionvacasacum { get; set; } = null!;
        public string? Accionvacasgoceadic { get; set; }
        public string? Accionvacasacumadic { get; set; }
        public string? Consecempleado { get; set; }
        public string PaginaSch { get; set; } = null!;
        public string? Centrocosto { get; set; }
        public string? Nomina { get; set; }
        public string? Horario { get; set; }
        public string? EstadoEmp { get; set; }
        public string? Conceptosbases { get; set; }
        public byte NoteExistsFlag { get; set; }
        public DateTime RecordDate { get; set; }
        public Guid RowPointer { get; set; }
        public string CreatedBy { get; set; } = null!;
        public string UpdatedBy { get; set; } = null!;
        public DateTime CreateDate { get; set; }
    }
}
